using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using shopApp.business.Abstract;
using shopApp.business.Concrete;
using shopApp.data.Abstract;
using shopApp.data.Concrete.EfCore;
using ShopApp.webui.EmailServices;
using ShopApp.webui.Identity;

namespace ShopApp.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(_configuration.GetConnectionString("MssqlConnection")));
            services.AddDbContext<ShopContext>(options => options.UseSqlServer(_configuration.GetConnectionString("MssqlConnection")));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
        
            services.Configure<IdentityOptions>(options =>
            {
                //Pass
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;//küçük harf zorunluluğu
                options.Password.RequireUppercase = true;//büyük harf
                options.Password.RequireNonAlphanumeric = true; //alfoümerik değer
                options.Password.RequiredLength = 6; //6 karakter

                //LockOut
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                //user
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true; //mail onayı
                options.SignIn.RequireConfirmedPhoneNumber = false;//telefon onayı
                                                                   // options.User.AllowedUserNameCharacters="";         

            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied"; //giiriş yapmış ancak yetkisi olmayan sayfa için yönlendirme
                options.SlidingExpiration = true; //varsayılan; 20 dk içinde bir haraket olmazsa cookie devre dışı olur ancak true dersek 20 dk içinde bir hareket olursa 20 dk sayaı sıfırlar 
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60); //1 saat ayarladık 20 dk değil de 
                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true, //cookie sadece http talebiyle elde edilsin
                    Name = ".ShopApp.Security.Cookie",
                    SameSite = SameSiteMode.Strict,
                    //cookieye sahip olmak yeterli olmayack 
                };
            });
            //Cookie oluşurum için 
            // services.AddScoped<IProductRepository, EfCoreProductRepository>();
            // services.AddScoped<IOrderRepository, EfCoreOrderRepository>();
            // services.AddScoped<ICartRepository, EfCoreCartRepository>();
            // services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
            services.AddScoped<IEmailSender, SmtpEmailSender>(i =>
                 new SmtpEmailSender(
                     _configuration["EmailSender:Host"],
                     _configuration.GetValue<int>("EmailSender:Port"),
                     _configuration.GetValue<bool>("EmailSender:EnableSSL"),
                     _configuration["EmailSender:UserName"],
                     _configuration["EmailSender:Password"])
                );

            services.AddScoped<IUnitOfWorks, UnitOfWorks>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, UserManager<User> user, RoleManager<IdentityRole> roleManager, ICartService cartService)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
                app.UseStaticFiles();
                app.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                    RequestPath = "/modules"
                });
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            //localhost:5000
            //localhots:5000/Products
            //localhots:5000/Products/5


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "orders",
                   pattern: "orders",
                   defaults: new { controller = "Cart", action = "Orders" }
                 );
                endpoints.MapControllerRoute(
                     name: "checkout",
                     pattern: "checkout",
                     defaults: new { controller = "Cart", action = "checkout" }
                   );
                endpoints.MapControllerRoute(
                   name: "cart",
                   pattern: "cart",
                   defaults: new { controller = "Cart", action = "Index" }
                 );
                endpoints.MapControllerRoute(
                 name: "adminusers",
                 pattern: "admin/user/list",
                 defaults: new { controller = "Admin", action = "UserList" }
               );
                endpoints.MapControllerRoute(
                  name: "adminUserEdits",
                  pattern: "admin/user/{id?}",
                  defaults: new { controller = "Admin", action = "UserEdit" }
                );
                endpoints.MapControllerRoute(
                 name: "adminroleEdits",
                 pattern: "admin/role/{id?}",
                 defaults: new { controller = "Admin", action = "RoleEdit" }
               );
                endpoints.MapControllerRoute(
                  name: "adminroles",
                  pattern: "admin/role/list",
                  defaults: new { controller = "Admin", action = "RoleList" }
                );
                endpoints.MapControllerRoute(
                  name: "adminrolecreate",
                  pattern: "admin/role/create",
                  defaults: new { controller = "Admin", action = "RoleCreate" }
                );
                endpoints.MapControllerRoute(
                  name: "adminrolEdit",
                  pattern: "admin/role/edit",
                  defaults: new { controller = "Admin", action = "edit" }
                );
                endpoints.MapControllerRoute(
                name: "adminrolDelete",
                pattern: "admin/role/delete",
                defaults: new { controller = "Admin", action = "delete" }
                );
                endpoints.MapControllerRoute(
                  name: "search",
                  pattern: "search",
                  defaults: new { controller = "Home", action = "Search" }
                );
                endpoints.MapControllerRoute(
                  name: "adminproductcreate",
                  pattern: "admin/products/create",
                  defaults: new { controller = "Admin", action = "ProductCreate" }
                );
                endpoints.MapControllerRoute(
                  name: "adminproduct",
                  pattern: "admin/products",
                  defaults: new { controller = "Admin", action = "ProductList" }
                );
                endpoints.MapControllerRoute(
                  name: "adminproduct",
                  pattern: "admin/categories",
                  defaults: new { controller = "Admin", action = "CategoryList" }
                );
                endpoints.MapControllerRoute(
                  name: "admincategoryCreate",
                  pattern: "admin/categories/create",
                  defaults: new { controller = "Admin", action = "CreateCategory" }
                );
                endpoints.MapControllerRoute(
                   name: "adminproductlist",
                   pattern: "admin/products/{id?}",
                   defaults: new { controller = "Admin", action = "ProductEdit" }
                );
                endpoints.MapControllerRoute(
                  name: "admincategoryEdit",
                  pattern: "admin/categories/{id?}",
                  defaults: new { controller = "Admin", action = "CategorydEdit" }
                );
                endpoints.MapControllerRoute(
                  name: "productsDetails",
                  pattern: "{productUrl}",
                  defaults: new { controller = "Shop", action = "details" }
                );
                endpoints.MapControllerRoute(
                  name: "products",
                  pattern: "products/{category?}",
                  defaults: new { controller = "Shop", action = "list" }
                );
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
            SeedIdentity.Seed(user, roleManager,cartService, configuration).Wait();

        }
    }
}

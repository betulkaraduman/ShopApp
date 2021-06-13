using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using shopApp.business.Abstract;
using shopApp.business.Concrete;
using shopApp.data.Abstract;
using shopApp.data.Concrete.EfCore;
namespace shopApp.webApi
{
    public class Startup
    {
        
        readonly string MyAllowOrigins = "_myAllowOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MssqlConnection")));
            services.AddScoped<IUnitOfWorks, UnitOfWorks>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<ICategoryService, CategoryManager>();

            services.AddControllers();
        
            services.AddCors(options => {
                options.AddPolicy(
                    name: MyAllowOrigins,
                    builder => {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                    }
                );
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(MyAllowOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

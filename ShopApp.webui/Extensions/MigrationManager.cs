using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using shopApp.data.Concrete.EfCore;
using ShopApp.webui.Identity;

namespace ShopApp.webui.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scobe = host.Services.CreateScope())
            {
                using (var applicationContext = scobe.ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    try
                    {
                        applicationContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {
                        //Loglama
                        throw;
                    }
                }
                using (var shopContext = scobe.ServiceProvider.GetRequiredService<ShopContext>())
                {
                    try
                    {
                        shopContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {
                        //Loglama
                        throw;
                    }
                }
            }
            return host;
        }
    }
}
using CarWorkshop.Infrastructure.Persistence;
using CarWorkshop.Infrastructure.Seeders;
using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarWorkshopDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("CarWorkshop")));

            services.AddScoped<CarWorhskopSeeder>();
        }
    }
}

using DailyPlanner.DAL.Interceptors;
using DailyPlanner.DAL.Repositories;
using DailyPlanner.Domain.Entity;
using DailyPlanner.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DailyPlanner.DAL.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("PostgresSQL");

            services.AddSingleton<DateInterceptor>();
            services.AddDbContext<ApplicationDbContext>(options => 
            { 
                options.UseNpgsql(connectionString); 
            });
            services.InitRepositories();
        }

        private static void InitRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<Report>, BaseRepository<Report>>();
        }
    }
}

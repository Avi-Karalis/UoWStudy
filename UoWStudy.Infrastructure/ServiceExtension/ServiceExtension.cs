using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UoWStudy.Core.Interfaces;
using UoWStudy.Infrastructure.Repositories;

namespace UoWStudy.Infrastructure.ServiceExtension;
// in this class, we are registering the Dependency Injection services and configure that inside the Program.cs file inside
// the root project
    public static class ServiceExtension {
        public static IServiceCollection DIServices (this IServiceCollection services, IConfiguration config) {
            services.AddDbContext<DbContextClass>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }


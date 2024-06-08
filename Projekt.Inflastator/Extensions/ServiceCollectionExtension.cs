using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Projekt.Domain.Interface;
using Projekt.Infrastructure.CarWorkShopDB;
using Projekt.Infrastructure.Repositories;
using Projekt.Infrastructure.Seeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Infrastructure.Entensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CarWorkShopDBContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("CarWorkShop")));
            services.AddScoped<CarWorkShopSeeder>();
            services.AddScoped<ICarWorkShopRepository, CarWorkShopRepository>();
        }
    }
}

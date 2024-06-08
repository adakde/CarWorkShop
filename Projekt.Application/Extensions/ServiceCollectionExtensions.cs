using Microsoft.Extensions.DependencyInjection;
using Projekt.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services) 
        {
            services.AddScoped<ICarWorkShopService, CarWorkShopService>();
        }
    }
}

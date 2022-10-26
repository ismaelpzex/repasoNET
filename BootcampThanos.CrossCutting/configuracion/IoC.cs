using BootcampThanos.Application.Contracts.Servicios;
using BootcampThanos.Application.Servicios;
using BootcampThanos.DataAccess;
using BootcampThanos.DataAccess.Contracts;
using BootcampThanos.DataAccess.Contracts.Repositories;
using BootcampThanos.DataAccess.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BootcampThanos.CrossCutting.configuracion
{
    public static class IoC
    {
        public static IServiceCollection Register(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductRepository, ProductRepository>();
            return services;
        }
    }
}

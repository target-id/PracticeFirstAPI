using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Practica.Dominio.Repositorio;
using Practica.Persistencia.Context;
using Practica.Persistencia.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Persistencia.Extensiones
{
    public static class ConfiguradorDeLosServicios 
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            // Aquí va el código para registrar tus servicios
            services.AddDbContext<BookstoreDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("default"));
            });

            services.AddScoped<IBookstoreRepositorio, BookstoreRepositorio>();
            return services;
        }
    }
    
}

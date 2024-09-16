using Microsoft.Extensions.DependencyInjection;
using Practica.Aplicacion.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Aplicacion.Extensiones
{
    public static class ConfiguradorAplicacionDeServicios
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services) 
        {
            services.AddScoped<BookstoreServicios>();
            return services;
        }
    }
}

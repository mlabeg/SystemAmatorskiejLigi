using LigaAmatorska.Domain.Interfaces;
using LigaAmatorska.Infrastructure.Presistence;
using LigaAmatorska.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Infrastructure.Extencions
{
    public static class ServiceCollectionExtencion
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LigaDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("LigaAmatorska")));

            services.AddScoped<IMeczRepository, MeczRepository>();
            services.AddScoped<IZawodnikRepository, ZawodnikRepository>();
            services.AddScoped<IDruzynaRepository, DruzynaRepository>();
            services.AddScoped<IStatystykiRepository, StatystykiRepository>();
            services.AddScoped<IWynikiDruzynRepository, WynikiDruzynRepository>();
            services.AddScoped<IAktualnosciRepository, IAktualnosciRepository>();
        }
    }
}
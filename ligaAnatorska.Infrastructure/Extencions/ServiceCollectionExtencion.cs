using ligaAmatorska.Domain.Interfaces;
using ligaAnatorska.Infrastructure.Presistence;
using ligaAnatorska.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ligaAnatorska.Infrastructure.Extencions
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
		}
	}
}
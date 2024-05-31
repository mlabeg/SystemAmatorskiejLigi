﻿using LigaAmatorska.Domain.Interfaces;
using LigaAmatorska.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaAmatorska.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IMeczService, MeczService>();
            services.AddScoped<IZawodnikService, ZawodnikService>();
            services.AddScoped<IDruzynaService, DruzynaService>();
        }
    }
}
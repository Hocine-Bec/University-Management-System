﻿using Applications.Interfaces.Services;
using Applications.Mappers;
using Applications.Services;
using Applications.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Applications
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IMyLogger, MyLogger>();

            return services;
        }
    }
}

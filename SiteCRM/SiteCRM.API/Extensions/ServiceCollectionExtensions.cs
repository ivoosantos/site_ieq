﻿using SiteCRM.Core.Repositories;
using SiteCRM.Infrastructure.Persistence.Repositories;

namespace SiteCRM.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISobreRepository, SobreRepository>();
            services.AddScoped<IGrupoRepository, GrupoRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}

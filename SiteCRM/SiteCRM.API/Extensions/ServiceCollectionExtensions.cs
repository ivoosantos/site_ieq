using SiteCRM.Core.Repositories;
using SiteCRM.Infrastructure.Persistence.Repositories;

namespace SiteCRM.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISobreRepository, SobreRepository>();

            return services;
        }
    }
}

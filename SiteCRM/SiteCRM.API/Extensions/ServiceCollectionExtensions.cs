using SiteCRM.Core.Repositories;
using SiteCRM.Core.Services;
using SiteCRM.Infrastructure.Auth;
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
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IMissoesRepository, MissoesRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<ICarouselRepository, CarouselRepository>();

            return services;
        }
    }
}

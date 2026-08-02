using Marquitos.Primer.Blazor.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Marquitos.Primer.Blazor.Extensions.Configuration
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMarquitosPrimerComponents(this IServiceCollection services)
        {
            // Services
            services.AddScoped<ExampleJsInterop>();
            services.AddScoped<SessionStorageService>();
            services.AddScoped<LocalStorageService>();
            services.AddScoped<ThemeStorageService>();

            return services;
        }
    }
}

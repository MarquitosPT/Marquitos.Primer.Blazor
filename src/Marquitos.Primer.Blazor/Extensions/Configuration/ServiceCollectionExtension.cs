using Marquitos.Primer.Blazor.JSInterop;
using Microsoft.Extensions.DependencyInjection;

namespace Marquitos.Primer.Blazor.Extensions.Configuration
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMarquitosPrimerComponents(this IServiceCollection services)
        {
            // Services
            services.AddScoped<IJSSessionStorageService, JSSessionStorageService>();
            services.AddScoped<IJSLocalStorageService, JSLocalStorageService>();
            services.AddScoped<IJSThemeService, JSThemeService>();

            return services;
        }
    }
}

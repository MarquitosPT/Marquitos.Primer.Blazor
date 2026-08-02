using Marquitos.Primer.Blazor.Base.Colors;
using Microsoft.JSInterop;

namespace Marquitos.Primer.Blazor.Services
{
    public class ThemeStorageService : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public ThemeStorageService(IJSRuntime js)
        {
            moduleTask = new(() => js.InvokeAsync<IJSObjectReference>(
                "import", "./_content/Marquitos.Primer.Blazor/themeStorageService.js").AsTask());
        }

        public async Task<ThemeColor> GetThemeColorAsync()
        {
            try
            {
                var module = await moduleTask.Value;
                var themeColorValue = await module.InvokeAsync<string>("theme.getThemeColor");

                return themeColorValue switch
                {
                    "light" => ThemeColor.Light,
                    "dark" => ThemeColor.Dark,
                    _ => ThemeColor.Light // Default to light if not set
                };
            }
            catch (Exception)
            {
                return ThemeColor.Light; // Default to light if an error occurs
            }
        }

        public async Task SetThemeColorAsync()
        {
            try
            {
                var module = await moduleTask.Value;
                await module.InvokeVoidAsync("theme.setCurrentThemeColor");
            }
            catch (Exception)
            { }
        }

        public async Task SetThemeColorAsync(ThemeColor theme)
        {
            try
            {
                var module = await moduleTask.Value;
                await module.InvokeVoidAsync("theme.setThemeColor", theme.Value);
            }
            catch (Exception)
            { }
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;

                try
                {
                    await module.DisposeAsync();
                }
                catch (Exception)
                { }
            }
        }
    }

}

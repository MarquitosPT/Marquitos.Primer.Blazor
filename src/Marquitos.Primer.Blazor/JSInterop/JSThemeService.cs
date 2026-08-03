using Marquitos.Primer.Blazor.Base.Colors;
using Microsoft.JSInterop;

namespace Marquitos.Primer.Blazor.JSInterop
{
    /// <summary>
    /// Provides an implementation of <see cref="IJSThemeService"/> for interacting with JavaScript to manage theme colors in a Blazor application.
    /// </summary>
    /// <param name="JSRuntime">The JavaScript runtime instance.</param>
    internal class JSThemeService(IJSRuntime JSRuntime) : IJSThemeService
    {
        private readonly IJSRuntime _jsRuntime = JSRuntime;

        public async Task<ThemeColor> GetThemeColorAsync()
        {
            var theme = await _jsRuntime.InvokeAsync<string>("themeProvider.getThemeColor");

            return theme switch
            {
                "light" => ThemeColor.Light,
                "dark" => ThemeColor.Dark,
                _ => ThemeColor.Light // Default to light if not set
            };
        }

        public async Task SetThemeColorAsync(ThemeColor theme)
        {
            await _jsRuntime.InvokeVoidAsync("themeProvider.setThemeColor", theme.Value);
        }

        public async Task<ThemeColor> ToggleThemeColorAsync()
        {
            var newTheme = await _jsRuntime.InvokeAsync<string>("themeProvider.toggleThemeColor");

            return newTheme switch
            {
                "light" => ThemeColor.Light,
                "dark" => ThemeColor.Dark,
                _ => ThemeColor.Light // Default to light if not set
            };
        }
    }
}

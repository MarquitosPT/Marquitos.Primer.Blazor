using Marquitos.Primer.Blazor.Base.Colors;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace Marquitos.Primer.Blazor.Theme
{
    /// <summary>
    /// A Blazor component that provides a theme toggler for switching between light and dark modes.
    /// </summary>
    public partial class ThemeToggler: ComponentBase
    {
        private string _title = "Switch to dark mode";

        [Inject]
        private IJSRuntime JSRuntime { get; set; } = default!;

        /// <summary>
        /// Gets the current theme color.
        /// </summary>
        public ThemeColor CurrentTheme { get; private set; } = ThemeColor.Light;

        /// <summary>
        /// Gets or sets the message displayed when switching to dark mode.
        /// </summary>
        [Parameter]
        public string SwitchToDarkModeMessage { get; set; } = "Switch to dark mode";

        /// <summary>
        /// Gets or sets the message displayed when switching to light mode.
        /// </summary>
        [Parameter]
        public string SwitchToLightModeMessage { get; set; } = "Switch to light mode";

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            var currentTheme = CurrentTheme;
            var theme = await JSRuntime.InvokeAsync<string>("themeProvider.getThemeColor");

            CurrentTheme = theme switch
            {
                "light" => ThemeColor.Light,
                "dark" => ThemeColor.Dark,
                _ => ThemeColor.Light // Default to light if not set
            };

            _title = CurrentTheme == ThemeColor.Light ? SwitchToDarkModeMessage : SwitchToLightModeMessage;

            if (currentTheme != CurrentTheme)
            {
                StateHasChanged();
            }
        }

        private async Task ToggleThemeAsync(MouseEventArgs args)
        {
            var newTheme = await JSRuntime.InvokeAsync<string>("themeProvider.toggleThemeColor");

            CurrentTheme = newTheme switch
            {
                "light" => ThemeColor.Light,
                "dark" => ThemeColor.Dark,
                _ => ThemeColor.Light // Default to light if not set
            };

            _title = CurrentTheme == ThemeColor.Light ? SwitchToDarkModeMessage : SwitchToLightModeMessage;

            StateHasChanged();
        }
    }
}

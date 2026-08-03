using Marquitos.Primer.Blazor.Base.Colors;

namespace Marquitos.Primer.Blazor.JSInterop
{
    /// <summary>
    /// Defines an interface for interacting with JavaScript to manage theme colors in a Blazor application.
    /// </summary>
    public interface IJSThemeService
    {
        /// <summary>
        /// Gets the current theme color.
        /// </summary>
        /// <returns>The current theme color.</returns>
        Task<ThemeColor> GetThemeColorAsync();

        /// <summary>
        /// Sets the theme color to the specified value.
        /// </summary>
        /// <param name="theme">The theme color to set.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task SetThemeColorAsync(ThemeColor theme);

        /// <summary>
        /// Toggles the theme color between light and dark.
        /// </summary>
        /// <returns>The new theme color after toggling.</returns>
        Task<ThemeColor> ToggleThemeColorAsync();
    }
}

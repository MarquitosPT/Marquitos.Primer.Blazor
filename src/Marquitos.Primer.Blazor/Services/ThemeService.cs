using Marquitos.Primer.Blazor.Base.Colors;

namespace Marquitos.Primer.Blazor.Services
{
    public class ThemeService
    {
        internal event EventHandler<ThemeColor>? OnThemeChanged;

        public ThemeColor Theme { get; private set; } = ThemeColor.Light;

        public async Task SetThemeAsync(ThemeColor theme)
        {
            if (Theme != theme)
            {
                Theme = theme;

                if (OnThemeChanged != null)
                {
                    try
                    {
                        OnThemeChanged.Invoke(this, theme);
                    }
                    catch (Exception)
                    { }
                }
            }

            await Task.CompletedTask;
        }
    }
}

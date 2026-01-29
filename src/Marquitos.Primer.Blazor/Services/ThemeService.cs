using Marquitos.Primer.Blazor.Base.Colors;

namespace Marquitos.Primer.Blazor.Services
{
    public class ThemeService
    {
        private bool initialized = false;

        internal event EventHandler<ThemeColor>? OnThemeChanged;

        public ThemeColor Theme { get; private set; } = ThemeColor.Light;

        internal async Task<ThemeColor> InitializeThemeAsync(ThemeColor theme)
        {
            if (!initialized)
            {
                Theme = theme;

                initialized = true;
            }

            return await Task.FromResult(Theme);
        }

        public async Task SetThemeAsync(ThemeColor theme)
        {
            if (!initialized)
            {
                throw new InvalidOperationException("ThemeService must be initialized before setting the theme. Place the 'ThemeProvider' component in you main layout.");
            }

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

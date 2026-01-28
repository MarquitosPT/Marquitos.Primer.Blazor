using Marquitos.Primer.Blazor.Base.Colors;
using Marquitos.Primer.Blazor.Services;
using Microsoft.AspNetCore.Components;

namespace Marquitos.Primer.Blazor.Theme
{
    public partial class ThemeProvider : ComponentBase, IDisposable
    {
        [Inject] private ThemeService ThemeService { get; set; } = default!;

        [Parameter] public RenderFragment? ChildContent { get; set; }

        [Parameter] public ThemeColor Theme { get; set; } = ThemeColor.Light;

        protected override async Task OnInitializedAsync()
        {
            await ThemeService.SetThemeAsync(Theme);

            ThemeService.OnThemeChanged += HandleThemeChanged;
        }

        public void Dispose()
        {
            ThemeService.OnThemeChanged -= HandleThemeChanged;
        }

        private void HandleThemeChanged(object? sender, ThemeColor theme)
        {
            Theme = theme;

            InvokeAsync(StateHasChanged);
        }
    }
}

using Marquitos.Primer.Blazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;

namespace Marquitos.Primer.Blazor.Theme
{
    public partial class ThemeProvider : ComponentBase, IDisposable
    {
        [Inject]
        public ThemeStorageService ThemeStorage { get; set; } = default!;

        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        protected override void OnInitialized()
        {
            NavigationManager.LocationChanged += OnLocationChanged;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await ThemeStorage.SetThemeColorAsync();
        }

        private async void OnLocationChanged(object? sender, LocationChangedEventArgs args)
        {
            await InvokeAsync(StateHasChanged);
        }

        void IDisposable.Dispose()
        {
            NavigationManager.LocationChanged -= OnLocationChanged;
        }
    }
}

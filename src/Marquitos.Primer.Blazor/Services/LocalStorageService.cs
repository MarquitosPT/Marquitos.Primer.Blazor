using Microsoft.JSInterop;

namespace Marquitos.Primer.Blazor.Services
{
    public class LocalStorageService
    {
        private readonly IJSRuntime _js;

        public LocalStorageService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task SetAsync(string key, string value)
        {
            await _js.InvokeVoidAsync("localStorage.setItem", key, value);
        }

        public async Task<string?> GetAsync(string key)
        {
            return await _js.InvokeAsync<string>("localStorage.getItem", key);
        }
    }

}

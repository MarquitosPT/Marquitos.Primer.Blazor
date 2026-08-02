using Microsoft.JSInterop;

namespace Marquitos.Primer.Blazor.Services
{
    public class SessionStorageService
    {
        private readonly IJSRuntime _js;

        public SessionStorageService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task SetAsync(string key, string value)
        {
            await _js.InvokeVoidAsync("sessionStorage.setItem", key, value);
        }

        public async Task<string?> GetAsync(string key)
        {
            return await _js.InvokeAsync<string>("sessionStorage.getItem", key);
        }
    }

}

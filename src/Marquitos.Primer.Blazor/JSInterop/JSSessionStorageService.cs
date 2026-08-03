using Microsoft.JSInterop;

namespace Marquitos.Primer.Blazor.JSInterop
{
    /// <summary>
    /// Defines a service for interacting with JavaScript to manage session storage in a Blazor application.
    /// </summary>
    /// <param name="js">The JavaScript runtime instance.</param>
    internal class JSSessionStorageService(IJSRuntime js) : IJSSessionStorageService
    {
        private readonly IJSRuntime _js = js;

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

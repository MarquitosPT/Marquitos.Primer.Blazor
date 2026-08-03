namespace Marquitos.Primer.Blazor.JSInterop
{
    /// <summary>
    /// Defines an interface for interacting with JavaScript to manage local storage in a Blazor application.
    /// </summary>
    public interface IJSLocalStorageService
    {
        /// <summary>
        /// Sets a value in the local storage for the specified key.
        /// </summary>
        /// <param name="key">The key to set in local storage.</param>
        /// <param name="value">The value to set for the specified key.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task SetAsync(string key, string value);

        /// <summary>
        /// Gets a value from the local storage for the specified key.
        /// </summary>
        /// <param name="key">The key to get from local storage.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the value for the specified key, or null if the key does not exist.</returns>  
        Task<string?> GetAsync(string key);
    }
}

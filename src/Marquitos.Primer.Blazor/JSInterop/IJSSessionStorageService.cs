namespace Marquitos.Primer.Blazor.JSInterop
{
    /// <summary>
    /// Defines an interface for interacting with JavaScript to manage session storage in a Blazor application.
    /// </summary>
    public interface IJSSessionStorageService
    {
        /// <summary>
        /// Sets a value in the session storage for the specified key.
        /// </summary>
        /// <param name="key">The key of the item to set in session storage.</param>
        /// <param name="value">The value to set for the specified key.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task SetAsync(string key, string value);

        /// <summary>
        /// Gets a value from the session storage for the specified key.
        /// </summary>
        /// <param name="key">The key of the item to get from session storage.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the value associated with the specified key, or null if the key does not exist.</returns>  
        Task<string?> GetAsync(string key);
    }
}

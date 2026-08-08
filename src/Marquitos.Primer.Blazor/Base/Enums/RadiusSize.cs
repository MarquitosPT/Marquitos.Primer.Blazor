namespace Marquitos.Primer.Blazor.Base.Enums
{
    /// <summary>
    /// Represents the size of the border radius for UI elements.
    /// </summary>
    public enum RadiusSize
    {
        /// <summary>
        /// No border radius.
        /// </summary>
        None = 0,
        /// <summary>
        /// Small border radius (3px).
        /// </summary>
        Small = 1,
        /// <summary>
        /// Medium border radius (6px).
        /// </summary>
        Medium = 2,
        /// <summary>
        /// Default border radius (same as Medium).
        /// </summary>
        Default = Medium,
        /// <summary>
        /// Large border radius (12px).
        /// </summary>
        Large = 3,
        /// <summary>
        /// Full border radius (circular).
        /// </summary>
        Full = 4
    }
}

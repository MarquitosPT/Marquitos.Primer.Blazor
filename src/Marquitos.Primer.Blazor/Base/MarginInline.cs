using Marquitos.Primer.Blazor.Base.Enums;

namespace Marquitos.Primer.Blazor.Base
{
    /// <summary>
    /// Represents the inline margin for UI elements, allowing customization of the start and end margins.
    /// </summary>
    public sealed record MarginInline
    {
        /// <summary>
        /// Gets or sets the start margin.
        /// </summary>
        public SpaceSize Start { get; set; } = SpaceSize.None;

        /// <summary>
        /// Gets or sets the end margin.
        /// </summary>
        public SpaceSize End { get; set; } = SpaceSize.None;

        /// <summary>
        /// Initializes a new instance of the <see cref="MarginInline"/> class with default values.
        /// </summary>
        public MarginInline()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarginInline"/> class with the specified margin for all sides.
        /// </summary>
        /// <param name="value">The margin size to apply to all sides.</param>
        public MarginInline(SpaceSize value)
        {
            Start = value;
            End = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarginInline"/> class with the specified margin for each side.
        /// </summary>
        /// <param name="start">The margin size to apply to the start side.</param>
        /// <param name="end">The margin size to apply to the end side.</param>
        public MarginInline(SpaceSize start = SpaceSize.None, SpaceSize end = SpaceSize.None)
        {
            Start = start;
            End = end;
        }

        /// <summary>
        /// Returns a string representation of the <see cref="MarginInline"/> instance, indicating the start and end margins.
        /// </summary>
        /// <returns>A string representation of the <see cref="MarginInline"/> instance.</returns>
        public override string ToString()
        {
            if (Start == End)
            {
                return $"m-inline-{(int)Start}";
            }
            else
            {
                return $"m-inline-start-{(int)Start} m-inline-end-{(int)End}";
            }
        }
    }
}

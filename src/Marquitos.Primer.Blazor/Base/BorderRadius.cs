using Marquitos.Primer.Blazor.Base.Enums;

namespace Marquitos.Primer.Blazor.Base
{
    /// <summary>
    /// Represents the border radius for UI elements, allowing customization of each corner's radius.
    /// </summary>
    public record BorderRadius
    {
        /// <summary>
        /// Gets or sets the border radius for the top-left corner.
        /// </summary>
        public RadiusSize TopLeft { get; set; } = 0;

        /// <summary>
        /// Gets or sets the border radius for the top-right corner.
        /// </summary>
        public RadiusSize TopRight { get; set; } = 0;

        /// <summary>
        /// Gets or sets the border radius for the bottom-left corner.
        /// </summary>
        public RadiusSize BottomLeft { get; set; } = 0;

        /// <summary>
        /// Gets or sets the border radius for the bottom-right corner.
        /// </summary>
        public RadiusSize BottomRight { get; set; } = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="BorderRadius"/> class with default values.
        /// </summary>
        public BorderRadius()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BorderRadius"/> class with the specified radius for all corners.
        /// </summary>
        /// <param name="value">The radius size to apply to all corners.</param>
        public BorderRadius(RadiusSize value)
        {
            TopLeft = value;
            TopRight = value;
            BottomRight = value;
            BottomLeft = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BorderRadius"/> class with the specified radius for the top and bottom corners.
        /// </summary>
        /// <param name="top">The radius size to apply to the top corners.</param>
        /// <param name="bottom">The radius size to apply to the bottom corners.</param>
        public BorderRadius(RadiusSize top = 0, RadiusSize bottom = 0)
        {
            TopLeft = top;
            TopRight = top;
            BottomRight = bottom;
            BottomLeft = bottom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BorderRadius"/> class with the specified radius for each corner.
        /// </summary>
        /// <param name="topLeft">The radius size to apply to the top-left corner.</param>
        /// <param name="topRight">The radius size to apply to the top-right corner.</param>
        /// <param name="bottomRight">The radius size to apply to the bottom-right corner.</param>
        /// <param name="bottomLeft">The radius size to apply to the bottom-left corner.</param>
        public BorderRadius(RadiusSize topLeft = 0, RadiusSize topRight = 0, RadiusSize bottomRight = 0, RadiusSize bottomLeft = 0)
        {
            TopLeft = topLeft;
            TopRight = topRight;
            BottomRight = bottomRight;
            BottomLeft = bottomLeft;
        }

        /// <summary>
        /// Returns a string representation of the border radius, formatted for CSS classes.
        /// </summary>
        /// <returns>A string representation of the border radius.</returns>
        public override string ToString()
        {
            if (TopLeft == TopRight && TopLeft == BottomRight && TopLeft == BottomLeft)
            {
                return $"b-radius-{(int)TopLeft}";
            }
            else if (TopLeft == BottomRight && BottomLeft == TopRight)
            {
                return $"btx-radius-{(int)TopLeft} bbx-radius-{(int)BottomLeft}";
            }
            else
            {
                return $"btl-radius-{(int)TopLeft} btr-radius-{(int)TopRight} bbr-radius-{(int)BottomRight} bbl-radius-{(int)BottomLeft}";
            }
        }
    }
}

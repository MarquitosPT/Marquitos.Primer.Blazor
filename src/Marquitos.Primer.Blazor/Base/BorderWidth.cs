using Marquitos.Primer.Blazor.Base.Enums;

namespace Marquitos.Primer.Blazor.Base
{
    /// <summary>
    /// Represents the border width for UI elements, allowing customization of each side's width.
    /// </summary>
    public sealed record BorderWidth
    {
        /// <summary>
        /// Gets or sets the border width for the top side.
        /// </summary>
        public BorderSize Top { get; set; } = 0;

        /// <summary>
        /// Gets or sets the border width for the right side.
        /// </summary>
        public BorderSize Right { get; set; } = 0;

        /// <summary>
        /// Gets or sets the border width for the bottom side.
        /// </summary>
        public BorderSize Bottom { get; set; } = 0;

        /// <summary>
        /// Gets or sets the border width for the left side.
        /// </summary>
        public BorderSize Left { get; set; } = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="BorderWidth"/> class with default values.
        /// </summary>
        public BorderWidth()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BorderWidth"/> class with the specified width for all sides.
        /// </summary>
        /// <param name="value">The border size to apply to all sides.</param>
        public BorderWidth(BorderSize value)
        {
            Top = value;
            Right = value;
            Bottom = value;
            Left = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BorderWidth"/> class with the specified width for the horizontal and vertical sides.
        /// </summary>
        /// <param name="x">The border size to apply to the left and right sides.</param>
        /// <param name="y">The border size to apply to the top and bottom sides.</param>
        public BorderWidth(BorderSize x = 0, BorderSize y = 0)
        {
            Top = y;
            Right = x;
            Bottom = y;
            Left = x;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BorderWidth"/> class with the specified width for each side.
        /// </summary>
        /// <param name="top">The border size to apply to the top side.</param>
        /// <param name="right">The border size to apply to the right side.</param>
        /// <param name="bottom">The border size to apply to the bottom side.</param>
        /// <param name="left">The border size to apply to the left side.</param>
        public BorderWidth(BorderSize top = 0, BorderSize right = 0, BorderSize bottom = 0, BorderSize left = 0)
        {
            Top = top;
            Right = right;
            Bottom = bottom;
            Left = left;
        }

        /// <summary>
        /// Returns a string representation of the border width, formatted for CSS classes.
        /// </summary>
        /// <returns>A string representation of the border width.</returns>
        public override string ToString()
        {
            if (Top == Bottom && Top == Left && Top == Right)
            {
                return $"b-width-{(int)Top}";
            }
            else if (Top == Bottom && Left == Right)
            {
                return $"by-width-{(int)Top} bx-width-{(int)Left}";
            }
            else
            {
                return $"bt-width-{(int)Top} br-width-{(int)Right} bb-width-{(int)Bottom} bl-width-{(int)Left}";
            }
        }
    }
}

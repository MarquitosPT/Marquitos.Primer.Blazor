using Marquitos.Primer.Blazor.Base.Enums;

namespace Marquitos.Primer.Blazor.Base
{
    /// <summary>
    /// Represents the margin for UI elements, allowing customization of the space around an element.
    /// </summary>
    public sealed record Margin
    {
        /// <summary>
        /// Gets or sets the margin for the top side.
        /// </summary>
        public SpaceSize Top { get; set; } = 0;

        /// <summary>
        /// Gets or sets the margin for the right side.
        /// </summary>
        public SpaceSize Right { get; set; } = 0;

        /// <summary>
        /// Gets or sets the margin for the bottom side.
        /// </summary>
        public SpaceSize Bottom { get; set; } = 0;

        /// <summary>
        /// Gets or sets the margin for the left side.
        /// </summary>
        public SpaceSize Left { get; set; } = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Margin"/> class with default values.
        /// </summary>
        public Margin()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Margin"/> class with the specified margin for all sides.
        /// </summary>
        /// <param name="value">The margin size to apply to all sides.</param>
        public Margin(SpaceSize value)
        {
            Top = value;
            Right = value;
            Bottom = value;
            Left = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Margin"/> class with the specified margin for the horizontal and vertical sides.
        /// </summary>
        /// <param name="x">The margin size to apply to the left and right sides.</param>
        /// <param name="y">The margin size to apply to the top and bottom sides.</param>
        public Margin(SpaceSize x = 0, SpaceSize y = 0)
        {
            Top = y;
            Right = x;
            Bottom = y;
            Left = x;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Margin"/> class with the specified margin for each side.
        /// </summary>
        /// <param name="top">The margin size to apply to the top side.</param>
        /// <param name="right">The margin size to apply to the right side.</param>
        /// <param name="bottom">The margin size to apply to the bottom side.</param>
        /// <param name="left">The margin size to apply to the left side.</param>
        public Margin(SpaceSize top = 0, SpaceSize right = 0, SpaceSize bottom = 0, SpaceSize left = 0)
        {
            Top = top;
            Right = right;
            Bottom = bottom;
            Left = left;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Margin"/> class with the specified block and inline margins.
        /// </summary>
        /// <param name="block">The block margin to apply to the top and bottom sides.</param>
        /// <param name="inline">The inline margin to apply to the left and right sides.</param>
        public Margin(MarginBlock block, MarginInline inline)
        {
            Top = block.Start;
            Bottom= block.End;
            Left = inline.Start;
            Right = inline.End;
        }
        
        /// <summary>
        /// Returns a string representation of the margin, formatted for CSS classes.
        /// </summary>
        /// <returns>A string representation of the margin.</returns>
        public override string ToString()
        {
            if (Top == Bottom && Top == Left && Top == Right)
            {
                return $"m-{(int)Top}";
            }
            else if (Top == Bottom && Left == Right)
            {
                return $"my-{(int)Top} mx-{(int)Left}";
            }
            else
            {
                return $"mt-{(int)Top} mr-{(int)Right} mb-{(int)Bottom} ml-{(int)Left}";
            }
        }
    }
}

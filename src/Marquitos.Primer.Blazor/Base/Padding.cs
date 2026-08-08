using Marquitos.Primer.Blazor.Base.Enums;

namespace Marquitos.Primer.Blazor.Base
{
    /// <summary>
    /// Represents the padding for UI elements, allowing customization of padding on each side (top, right, bottom, left).
    /// </summary>
    public sealed record Padding
    {
        /// <summary>
        /// Gets or sets the top padding.
        /// </summary>
        public SpaceSize Top { get; set; } = 0;

        /// <summary>
        /// Gets or sets the right padding.
        /// </summary>
        public SpaceSize Right { get; set; } = 0;

        /// <summary>
        /// Gets or sets the bottom padding.
        /// </summary>
        public SpaceSize Bottom { get; set; } = 0;

        /// <summary>
        /// Gets or sets the left padding.
        /// </summary>
        public SpaceSize Left { get; set; } = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Padding"/> class with default values.
        /// </summary>
        public Padding()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Padding"/> class with the specified padding for all sides.
        /// </summary>
        /// <param name="value">The padding size to apply to all sides.</param>
        public Padding(SpaceSize value)
        {
            Top = value;
            Right = value;
            Bottom = value;
            Left = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Padding"/> class with the specified horizontal and vertical padding.
        /// </summary>
        /// <param name="x">The padding size to apply to the left and right sides.</param>
        /// <param name="y">The padding size to apply to the top and bottom sides.</param>
        public Padding(SpaceSize x = 0, SpaceSize y = 0)
        {
            Top = y;
            Right = x;
            Bottom = y;
            Left = x;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Padding"/> class with the specified padding for each side.
        /// </summary>
        /// <param name="top">The padding size to apply to the top side.</param>
        /// <param name="right">The padding size to apply to the right side.</param>
        /// <param name="bottom">The padding size to apply to the bottom side.</param>
        /// <param name="left">The padding size to apply to the left side.</param>
        public Padding(SpaceSize top = 0, SpaceSize right = 0, SpaceSize bottom = 0, SpaceSize left = 0)
        {
            Top = top;
            Right = right;
            Bottom = bottom;
            Left = left;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Padding"/> class with the specified block and inline padding.
        /// </summary>
        /// <param name="block">The block padding to apply to the top and bottom sides.</param>
        /// <param name="inline">The inline padding to apply to the left and right sides.</param>
        public Padding(PaddingBlock block, PaddingInline inline)
        {
            Top = block.Start;
            Bottom= block.End;
            Left = inline.Start;
            Right = inline.End;
        }

        /// <summary>
        /// Returns a string representation of the <see cref="Padding"/> instance, indicating the padding for each side.
        /// </summary>
        /// <returns>A string representation of the <see cref="Padding"/> instance.</returns>
        public override string ToString()
        {
            if (Top == Bottom && Top == Left && Top == Right)
            {
                return $"p-{(int)Top}";
            }
            else if (Top == Bottom && Left == Right)
            {
                return $"py-{(int)Top} px-{(int)Left}";
            }
            else
            {
                return $"pt-{(int)Top} pr-{(int)Right} pb-{(int)Bottom} pl-{(int)Left}";
            }
        }
    }
}

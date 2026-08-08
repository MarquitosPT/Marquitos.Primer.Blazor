using Marquitos.Primer.Blazor.Base.Enums;

namespace Marquitos.Primer.Blazor.Base
{
    /// <summary>
    /// Represents the padding for the block (vertical) direction of UI elements, allowing customization of the start and end padding.
    /// </summary>
    public sealed record PaddingBlock
    {
        /// <summary>
        /// Gets or sets the start padding.
        /// </summary>
        public SpaceSize Start { get; set; } = SpaceSize.None;

        /// <summary>
        /// Gets or sets the end padding.
        /// </summary>
        public SpaceSize End { get; set; } = SpaceSize.None;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaddingBlock"/> class with default values.
        /// </summary>
        public PaddingBlock()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaddingBlock"/> class with the specified padding for all sides.
        /// </summary>
        /// <param name="value">The padding size to apply to all sides.</param>
        public PaddingBlock(SpaceSize value)
        {
            Start = value;
            End = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaddingBlock"/> class with the specified padding for each side.
        /// </summary>
        /// <param name="start">The padding size to apply to the start side.</param>
        /// <param name="end">The padding size to apply to the end side.</param>
        public PaddingBlock(SpaceSize start = SpaceSize.None, SpaceSize end = SpaceSize.None)
        {
            Start = start;
            End = end;
        }

        /// <summary>
        /// Returns a string representation of the <see cref="PaddingBlock"/> instance, indicating the padding for each side.
        /// </summary>
        /// <returns>A string representation of the <see cref="PaddingBlock"/> instance.</returns>
        public override string ToString()
        {
            if (Start == End)
            {
                return $"p-block-{(int)Start}";
            }
            else
            {
                return $"p-block-start-{(int)Start} p-block-end-{(int)End}";
            }
        }
    }
}

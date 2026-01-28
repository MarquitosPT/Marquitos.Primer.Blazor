using Marquitos.Primer.Blazor.Base.Colors;
using Marquitos.Primer.Blazor.Base.Sizes;
using Microsoft.AspNetCore.Components;

namespace Marquitos.Primer.Blazor.Layout
{
    /// <summary>
    /// The box component is a versatile layout component that is intended to simplify the process
    /// of adding one-off styles such as padding, margin, background color, and border to (or around) an element.
    /// box provides convenient and comprehensive access to Primer Brand’s underlying Primitives,
    /// such as the spacing scale and functional design tokens for color and borders.
    /// While the box component is highly customizable and can be used to create complex layouts,
    /// it is important to use it judiciously and only when necessary.
    /// </summary>
    public partial class Box
    {
        [Parameter] public RenderFragment? ChildContent { get; set; }

        /// <summary>
        /// Adds padding to all internal sides of the Box.
        /// </summary>
        [Parameter] public PaddingSize? Padding { get; set; }

        /// <summary>
        /// Adds padding to the internal block start (top) side of the Box.
        /// </summary>
        [Parameter] public PaddingSize? PaddingBlockStart { get; set; }

        /// <summary>
        /// Adds padding to the internal block end (bottom) side of the Box.
        /// </summary>
        [Parameter] public PaddingSize? PaddingBlockEnd { get; set; }

        /// <summary>
        /// Adds padding to the internal inline start (left) side of the Box.
        /// </summary>
        [Parameter] public PaddingSize? PaddingInlineStart { get; set; }

        /// <summary>
        /// Adds padding to the internal inline end (right) of the Box.
        /// </summary>
        [Parameter] public PaddingSize? PaddingInlineEnd { get; set; }

        /// <summary>
        /// Adds margin to all external sides of the Box.
        /// </summary>
        [Parameter] public MarginSize? Margin { get; set; }

        /// <summary>
        /// Adds margin to the external block start (top) side of the Box.
        /// </summary>
        [Parameter] public MarginSize? MarginBlockStart { get; set; }

        /// <summary>
        /// Adds margin to the external block end (bottom) side of the Box.
        /// </summary>
        [Parameter] public MarginSize? MarginBlockEnd { get; set; }

        /// <summary>
        /// Adds margin to the external inline start (left) side of the Box.
        /// </summary>
        [Parameter] public MarginSize? MarginInlineStart { get; set; }

        /// <summary>
        /// Adds margin to the external inline end (right) side of the Box.
        /// </summary>
        [Parameter] public MarginSize? MarginInlineEnd { get; set; }

        /// <summary>
        /// Applies a system-level background color to the Box.
        /// </summary>
        [Parameter] public BackgroundColor? BackgroundColor { get; set; }

        /// <summary>
        /// Applies a system-level border radius value to the Box.
        /// </summary>
        [Parameter] public BorderRadius? BorderRadius { get; set; }

        /// <summary>
        /// Applies a system-level border width value to the Box.
        /// </summary>
        [Parameter] public BorderWidth? BorderWidth { get; set; }

        /// <summary>
        /// Applies a system-level border width value to block-start side of the Box.
        /// </summary>
        [Parameter] public BorderWidth? BorderBlockStartWidth { get; set; }

        /// <summary>
        /// Applies a system-level border width value to block-end side of the Box.
        /// </summary>
        [Parameter] public BorderWidth? BorderBlockEndWidth { get; set; }

        /// <summary>
        /// Applies a system-level border width value to inline-start side of the Box.
        /// </summary>
        [Parameter] public BorderWidth? BorderInlineStartWidth { get; set; }

        /// <summary>
        /// Applies a system-level border width value to inline-end side of the Box.
        /// </summary>
        [Parameter] public BorderWidth? BorderInlineEndWidth { get; set; }

        /// <summary>
        /// Applies a system-level border color value to the Box.
        /// </summary>
        [Parameter] public BorderColor? BorderColor { get; set; }

        /// <summary>
        /// Applies border style. Values correspond to the CSS border-style property.
        /// </summary>
        [Parameter] public BorderStyle? BorderStyle { get; set; }

        private string? GetBorderStyleClass()
        {
            if (BorderStyle is not null)
            {
                return $"Box-borderStyle--{BorderStyle}";
            }
            return null;
        }

        private string? GetBorderColorClass()
        {
            if (BorderColor is not null)
            {
                return $"Box-borderColor--{BorderColor}";
            }
            return null;
        }

        private string? GetBorderWidthClass()
        {
            var result = "";
            if (BorderWidth is not null)
            {
                result = $"Box-borderWidth--{BorderWidth}";
            }
            if (BorderBlockStartWidth is not null)
            {
                result += $" Box-borderBlockStartWidth--{BorderBlockStartWidth}";
            }
            if (BorderBlockEndWidth is not null)
            {
                result += $" Box-borderBlockEndWidth--{BorderBlockEndWidth}";
            }
            if (BorderInlineStartWidth is not null)
            {
                result += $" Box-borderInlineStartWidth--{BorderInlineStartWidth}";
            }
            if (BorderInlineEndWidth is not null)
            {
                result += $" Box-borderInlineEndWidth--{BorderInlineEndWidth}";
            }

            return result.Trim();
        }

        private string? GetBorderRadiusClass()
        {
            if (BorderRadius is not null)
            {
                return $"Box-borderRadius--{BorderRadius}";
            }
            return null;
        }

        private string? GetBackgroundColorClass()
        {
            if (BackgroundColor is not null)
            {
                return $"Box-backgroundColor--{BackgroundColor}";
            }
            return null;
        }

        private string? GetMarginClass()
        {
            var result = "";
            if (Margin is not null)
            {
                result = $"Box-margin--{Margin}";
            }
            if (MarginBlockStart is not null)
            {
                result += $" Box-marginBlockStart--{MarginBlockStart}";
            }
            if (MarginBlockEnd is not null)
            {
                result += $" Box-marginBlockEnd--{MarginBlockEnd}";
            }
            if (MarginInlineStart is not null)
            {
                result += $" Box-marginInlineStart--{MarginInlineStart}";
            }
            if (MarginInlineEnd is not null)
            {
                result += $" Box-marginInlineEnd--{MarginInlineEnd}";
            }
            return result.Trim();
        }

        private string? GetPaddingClass()
        {
            var result = "";

            if (Padding is not null)
            {
                result = $"Box-padding--{Padding}";
            }

            if (PaddingBlockStart is not null)
            {
                result += $" Box-paddingBlockStart--{PaddingBlockStart}";
            }

            if (PaddingBlockEnd is not null)
            {
                result += $" Box-paddingBlockEnd--{PaddingBlockEnd}";
            }

            if (PaddingInlineStart is not null)
            {
                result += $" Box-paddingInlineStart--{PaddingInlineStart}";
            }

            if (PaddingInlineEnd is not null)
            {
                result += $" Box-paddingInlineEnd--{PaddingInlineEnd}";
            }
            return result.Trim();
        }

        private string? GetBoxClasses()
        {
            var marginClass = GetMarginClass();
            var paddingClass = GetPaddingClass();
            var backgroundColorClass = GetBackgroundColorClass();
            var borderRadiusClass = GetBorderRadiusClass();
            var borderWidthClass = GetBorderWidthClass();
            var borderColorClass = GetBorderColorClass();
            var borderStyleClass = GetBorderStyleClass();

            return $"{marginClass} {paddingClass} {backgroundColorClass} {borderRadiusClass} {borderWidthClass} {borderColorClass} {borderStyleClass}".Trim();
        }
    }
}

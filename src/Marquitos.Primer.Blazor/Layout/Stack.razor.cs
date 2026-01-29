using Marquitos.Primer.Blazor.Base.Functional;
using Marquitos.Primer.Blazor.Base.Sizes;
using Microsoft.AspNetCore.Components;

namespace Marquitos.Primer.Blazor.Layout
{
    public partial class Stack : ComponentBase
    {
        [Parameter] public RenderFragment? ChildContent { get; set; }

        /// <summary>
        /// Determines layout direction
        /// </summary>
        [Parameter] public Direction Direction { get; set; } = Direction.Vertical;

        /// <summary>
        /// Determines gap between items
        /// </summary>
        [Parameter] public SpacingSize? Spacing { get; set; } = SpacingSize.Condensed;

        /// <summary>
        /// Applies vertical alignment to child elements relative to the Stack
        /// </summary>
        [Parameter] public VerticalAlignment? VerticalAlignment { get; set; }

        /// <summary>
        /// Applies horizontal alignment to child elements relative to the Stack
        /// </summary>
        [Parameter] public HorizontalAlignment? HorizontalAlignment { get; set; }

        /// <summary>
        /// Determines padding applied to Stack parent
        /// </summary>
        [Parameter] public PaddingSize? Padding { get; set; } = PaddingSize.Condensed;

        /// <summary>
        /// Applies flex-wrap to the Stack
        /// </summary>
        [Parameter] public WrapMode? Wrap { get; set; }

        private string GetDirectionClass()
        {
            return $"Stack--{Direction}";
        }

        private string? GetSpacingClass()
        {
            if (Spacing is not null)
            {
                return $"Stack--gap-{Spacing}";
            }
            return null;
        }

        private string? GetVerticalAlignmentClass()
        {
            if (VerticalAlignment is not null)
            {
                return $"Stack--align-items-{VerticalAlignment}";
            }
            return null;
        }

        private string? GetHorizontalAlignmentClass()
        {
            if (HorizontalAlignment is not null)
            {
                return $"Stack--justify-content-{HorizontalAlignment}";
            }
            return null;
        }

        private string? GetPaddingClass()
        {
            if (Padding is not null)
            {
                return $"Stack--padding-{Padding}";
            }
            return null;
        }

        private string? GetWrapClass()
        {
            if (Wrap is not null)
            {
                return $"Stack-flexWrap--{Wrap}";
            }
            return null;
        }

        private string GetClasses()
        {
            var directionClass = GetDirectionClass();
            var spacingClass = GetSpacingClass();
            var verticalAlignmentClass = GetVerticalAlignmentClass();
            var horizontalAlignmentClass = GetHorizontalAlignmentClass();
            var paddingClass = GetPaddingClass();
            var wrapClass = GetWrapClass();

            return $"{directionClass} {spacingClass} {verticalAlignmentClass} {horizontalAlignmentClass} {paddingClass} {wrapClass}".Trim();
        }
    }
}

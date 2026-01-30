using Marquitos.Primer.Blazor.Base.Functional;
using Marquitos.Primer.Blazor.Base.Sizes;
using Microsoft.AspNetCore.Components;

namespace Marquitos.Primer.Blazor.Layout
{
    public partial class GridColumn : ComponentBase
    {
        [Parameter] public RenderFragment? ChildContent { get; set; }

        [Parameter] public ColumnSpan? Span { get; set; } //= ColumnSpan.S12;

        [Parameter] public ResponsiveSpan? ResponsiveSpan { get; set; }

        [Parameter] public ColumnIndex? Start { get; set; }

        [Parameter] public ResponsiveIndex? ResponsiveStart { get; set; }

        private string? GetResponsiveStartClass()
        {
            if (ResponsiveStart is not null)
            {
                var classes = new List<string>();
                foreach (var (size, index) in ResponsiveStart)
                {
                    classes.Add($"Grid__column--{size}-start-{index}");
                }
                return string.Join(" ", classes);
            }
            return null;
        }

        private string? GetStartClass()
        {
            if (Start is not null)
            {
                return $"Grid__column--start-{Start}";
            }
            return null;
        }

        private string? GetResponsiveSpanClass()
        {
            if (ResponsiveSpan is not null)
            {
                var classes = new List<string>();
                foreach (var (size, span) in ResponsiveSpan)
                {
                    classes.Add($"Grid__column--{size}-span-{span}");
                }
                return string.Join(" ", classes);
            }
            return null;
        }

        private string? GetSpanClass()
        {
            if (Span is not null)
            {
                return $"Grid__column--span-{Span}";
            }
            return null;
        }

        private string GetClasses()
        {
            var spanClass = GetSpanClass();
            var responsiveSpanClass = GetResponsiveSpanClass();
            var startClass = GetStartClass();
            var responsiveStartClass = GetResponsiveStartClass();

            return $"{spanClass} {responsiveSpanClass} {startClass} {responsiveStartClass}".Trim();
        }

        
    }
}

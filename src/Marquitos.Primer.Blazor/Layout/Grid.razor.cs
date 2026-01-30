using Microsoft.AspNetCore.Components;

namespace Marquitos.Primer.Blazor.Layout
{
    public partial class Grid : ComponentBase
    {
        [Parameter] public RenderFragment? ChildContent { get; set; }

        private string GetClasses()
        {
            

            return $"".Trim();
        }
    }
}

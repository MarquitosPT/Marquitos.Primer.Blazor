using System;
using System.Collections.Generic;
using System.Text;
using Marquitos.Primer.Blazor.Base.Sizes;

namespace Marquitos.Primer.Blazor.Base.Functional
{
    public class ResponsiveSpan : Dictionary<DisplaySize, ColumnSpan>
    {
        private ResponsiveSpan() { }

        public static ResponsiveSpan Create(params (DisplaySize size, ColumnSpan span)[] mappings)
        {
            var dict = new ResponsiveSpan();
            foreach (var (size, span) in mappings)
            {
                dict[size] = span;
            }
            return dict;
        }
    }
}

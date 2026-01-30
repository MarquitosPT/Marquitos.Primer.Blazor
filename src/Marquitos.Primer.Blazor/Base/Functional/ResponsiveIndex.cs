using System;
using System.Collections.Generic;
using System.Text;
using Marquitos.Primer.Blazor.Base.Sizes;

namespace Marquitos.Primer.Blazor.Base.Functional
{
    public class ResponsiveIndex : Dictionary<DisplaySize, ColumnIndex>
    {
        private ResponsiveIndex() { }

        public static ResponsiveIndex Create(params (DisplaySize size, ColumnIndex index)[] mappings)
        {
            var dict = new ResponsiveIndex();
            foreach (var (size, index) in mappings)
            {
                dict[size] = index;
            }
            return dict;
        }
    }
}

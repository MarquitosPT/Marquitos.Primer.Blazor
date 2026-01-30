namespace Marquitos.Primer.Blazor.Base.Sizes
{
    public sealed record DisplaySize
    {
        public string Value { get; }

        private DisplaySize(string value)
        {
            Value = value;
        }

        public static readonly DisplaySize XS = new("xsmall");
        public static readonly DisplaySize S = new("small");
        public static readonly DisplaySize M = new("medium");
        public static readonly DisplaySize L = new("large");
        public static readonly DisplaySize XL = new("xlarge");
        public static readonly DisplaySize XXL = new("xxlarge");

        public override string ToString() => Value;
    }
}

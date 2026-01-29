namespace Marquitos.Primer.Blazor.Base.Sizes
{
    public sealed record SpacingSize
    {
        public string Value { get; }

        private SpacingSize(string value)
        {
            Value = value;
        }

        public static readonly SpacingSize None = new("none");
        public static readonly SpacingSize Condensed = new("condensed");
        public static readonly SpacingSize Normal = new("normal");
        public static readonly SpacingSize Spacious = new("spacious");
        public static readonly SpacingSize P4 = new("4");
        public static readonly SpacingSize P8 = new("8");
        public static readonly SpacingSize P12 = new("12");
        public static readonly SpacingSize P16 = new("16");
        public static readonly SpacingSize P20 = new("20");
        public static readonly SpacingSize P24 = new("24");
        public static readonly SpacingSize P28 = new("28");
        public static readonly SpacingSize P32 = new("32");
        public static readonly SpacingSize P36 = new("36");
        public static readonly SpacingSize P40 = new("40");
        public static readonly SpacingSize P44 = new("44");
        public static readonly SpacingSize P48 = new("48");
        public static readonly SpacingSize P64 = new("64");
        public static readonly SpacingSize P80 = new("80");
        public static readonly SpacingSize P96 = new("96");
        public static readonly SpacingSize P112 = new("112");
        public static readonly SpacingSize P128 = new("128");

        public override string ToString() => Value;
    }
}

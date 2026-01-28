namespace Marquitos.Primer.Blazor.Base.Sizes
{
    public sealed record PaddingSize
    {
        public string Value { get; }

        private PaddingSize(string value)
        {
            Value = value;
        }

        public static readonly PaddingSize None = new("none");
        public static readonly PaddingSize Condensed = new("condensed");
        public static readonly PaddingSize Normal = new("normal");
        public static readonly PaddingSize Spacious = new("spacious");
        public static readonly PaddingSize P4 = new("4");
        public static readonly PaddingSize P8 = new("8");
        public static readonly PaddingSize P12 = new("12");
        public static readonly PaddingSize P16 = new("16");
        public static readonly PaddingSize P20 = new("20");
        public static readonly PaddingSize P24 = new("24");
        public static readonly PaddingSize P28 = new("28");
        public static readonly PaddingSize P32 = new("32");
        public static readonly PaddingSize P36 = new("36");
        public static readonly PaddingSize P40 = new("40");
        public static readonly PaddingSize P44 = new("44");
        public static readonly PaddingSize P48 = new("48");
        public static readonly PaddingSize P64 = new("64");
        public static readonly PaddingSize P80 = new("80");
        public static readonly PaddingSize P96 = new("96");
        public static readonly PaddingSize P112 = new("112");
        public static readonly PaddingSize P128 = new("128");

        public override string ToString() => Value;
    }
}

namespace Marquitos.Primer.Blazor.Base.Sizes
{
    public sealed record MarginSize
    {
        public string Value { get; }

        private MarginSize(string value)
        {
            Value = value;
        }

        public static readonly MarginSize None = new("none");
        public static readonly MarginSize Condensed = new("condensed");
        public static readonly MarginSize Normal = new("normal");
        public static readonly MarginSize Spacious = new("spacious");
        public static readonly MarginSize P4 = new("4");
        public static readonly MarginSize P8 = new("8");
        public static readonly MarginSize P12 = new("12");
        public static readonly MarginSize P16 = new("16");
        public static readonly MarginSize P20 = new("20");
        public static readonly MarginSize P24 = new("24");
        public static readonly MarginSize P28 = new("28");
        public static readonly MarginSize P32 = new("32");
        public static readonly MarginSize P36 = new("36");
        public static readonly MarginSize P40 = new("40");
        public static readonly MarginSize P44 = new("44");
        public static readonly MarginSize P48 = new("48");
        public static readonly MarginSize P64 = new("64");
        public static readonly MarginSize P80 = new("80");
        public static readonly MarginSize P96 = new("96");
        public static readonly MarginSize P112 = new("112");
        public static readonly MarginSize P128 = new("128");

        public override string ToString() => Value;
    }
}

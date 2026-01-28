namespace Marquitos.Primer.Blazor.Base.Sizes
{
    public sealed record BaseSize
    {
        public string Value { get; }

        private BaseSize(string value)
        {
            Value = value;
        }

        public static readonly BaseSize P4 = new("4");
        public static readonly BaseSize P8 = new("8");
        public static readonly BaseSize P12 = new("12");
        public static readonly BaseSize P16 = new("16");
        public static readonly BaseSize P20 = new("20");
        public static readonly BaseSize P24 = new("24");
        public static readonly BaseSize P28 = new("28");
        public static readonly BaseSize P32 = new("32");
        public static readonly BaseSize P36 = new("36");
        public static readonly BaseSize P40 = new("40");
        public static readonly BaseSize P44 = new("44");
        public static readonly BaseSize P48 = new("48");
        public static readonly BaseSize P64 = new("64");
        public static readonly BaseSize P80 = new("80");
        public static readonly BaseSize P96 = new("96");
        public static readonly BaseSize P112 = new("112");
        public static readonly BaseSize P128 = new("128");

        public override string ToString() => Value;
    }
}

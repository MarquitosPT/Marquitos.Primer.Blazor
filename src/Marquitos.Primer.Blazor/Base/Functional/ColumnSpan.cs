namespace Marquitos.Primer.Blazor.Base.Functional
{
    public sealed record ColumnSpan
    {
        public string Value { get; }

        private ColumnSpan(string value)
        {
            Value = value;
        }

        // Predefined column spans from 1 to 12
        public static readonly ColumnSpan S1 = new ("1");
        public static readonly ColumnSpan S2 = new("2");
        public static readonly ColumnSpan S3 = new("3");
        public static readonly ColumnSpan S4 = new("4");
        public static readonly ColumnSpan S5 = new("5");
        public static readonly ColumnSpan S6 = new("6");
        public static readonly ColumnSpan S7 = new("7");
        public static readonly ColumnSpan S8 = new("8");
        public static readonly ColumnSpan S9 = new("9");
        public static readonly ColumnSpan S10 = new("10");
        public static readonly ColumnSpan S11 = new("11");
        public static readonly ColumnSpan S12 = new("12");

        public override string ToString() => Value;
    }
}

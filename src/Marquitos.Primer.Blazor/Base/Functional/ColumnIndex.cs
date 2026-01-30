namespace Marquitos.Primer.Blazor.Base.Functional
{
    public sealed record ColumnIndex
    {
        public string Value { get; }

        private ColumnIndex(string value)
        {
            Value = value;
        }

        public static readonly ColumnIndex I1 = new ("1");
        public static readonly ColumnIndex I2 = new("2");
        public static readonly ColumnIndex I3 = new("3");
        public static readonly ColumnIndex I4 = new("4");
        public static readonly ColumnIndex I5 = new("5");
        public static readonly ColumnIndex I6 = new("6");
        public static readonly ColumnIndex I7 = new("7");
        public static readonly ColumnIndex I8 = new("8");
        public static readonly ColumnIndex I9 = new("9");
        public static readonly ColumnIndex I10 = new("10");
        public static readonly ColumnIndex I11 = new("11");
        public static readonly ColumnIndex I12 = new("12");

        public override string ToString() => Value;
    }
}

namespace Marquitos.Primer.Blazor.Base.Colors
{
    public sealed record ThemeColor
    {
        public string Value { get; }

        private ThemeColor(string value)
        {
            Value = value;
        }

        public static readonly ThemeColor Light = new("light");
        public static readonly ThemeColor Dark = new("dark");

        public override string ToString() => Value;
    }
}

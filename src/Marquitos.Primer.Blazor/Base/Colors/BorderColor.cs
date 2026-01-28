namespace Marquitos.Primer.Blazor.Base.Colors
{
    public sealed record BorderColor
    {
        public string Value { get; }

        private BorderColor(string value)
        {
            Value = value;
        }

        public static readonly BorderColor Default = new ("default");
        public static readonly BorderColor Muted = new("muted");
        public static readonly BorderColor Subtle = new("subtle");

        public override string ToString() => Value;
    }
}

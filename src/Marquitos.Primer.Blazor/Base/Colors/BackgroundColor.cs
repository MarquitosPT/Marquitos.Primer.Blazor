namespace Marquitos.Primer.Blazor.Base.Colors
{
    public sealed record BackgroundColor
    {
        public string Value { get; }

        private BackgroundColor(string value)
        {
            Value = value;
        }

        public static readonly BackgroundColor Default = new ("default");
        public static readonly BackgroundColor Inset = new("inset");
        public static readonly BackgroundColor Subtle = new("subtle");
        public static readonly BackgroundColor Overlay = new("overlay");

        public override string ToString() => Value;
    }
}

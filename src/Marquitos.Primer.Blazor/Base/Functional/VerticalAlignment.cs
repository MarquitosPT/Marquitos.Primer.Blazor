namespace Marquitos.Primer.Blazor.Base.Functional
{
    public sealed record VerticalAlignment
    {
        public string Value { get; }

        private VerticalAlignment(string value)
        {
            Value = value;
        }

        public static readonly VerticalAlignment Center = new ("center");
        public static readonly VerticalAlignment Start = new ("flex-start");
        public static readonly VerticalAlignment End = new ("flex-end");

        public override string ToString() => Value;
    }
}

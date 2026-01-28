namespace Marquitos.Primer.Blazor.Base.Sizes
{
    public sealed record BorderStyle
    {
        public string Value { get; }

        private BorderStyle(string value)
        {
            Value = value;
        }

        public static readonly BorderStyle Solid = new("solid");
        public static readonly BorderStyle None = new("none");

        public override string ToString() => Value;
    }
}

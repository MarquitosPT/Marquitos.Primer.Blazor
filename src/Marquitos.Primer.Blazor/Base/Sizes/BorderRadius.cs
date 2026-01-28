namespace Marquitos.Primer.Blazor.Base.Sizes
{
    public sealed record BorderRadius
    {
        public string Value { get; }

        private BorderRadius(string value)
        {
            Value = value;
        }

        public static readonly BorderRadius Small = new("small");
        public static readonly BorderRadius Medium = new("medium");
        public static readonly BorderRadius Large = new("large");
        public static readonly BorderRadius ExtraLarge = new("xlarge");
        public static readonly BorderRadius Full = new("full");

        public override string ToString() => Value;
    }
}

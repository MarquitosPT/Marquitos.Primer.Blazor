namespace Marquitos.Primer.Blazor.Base.Sizes
{
    public sealed record BorderWidth
    {
        public string Value { get; }

        private BorderWidth(string value)
        {
            Value = value;
        }

        public static readonly BorderWidth Thin = new("thin");
        public static readonly BorderWidth Thick = new("thick");
        public static readonly BorderWidth Thicker = new("thicker");

        public override string ToString() => Value;
    }
}

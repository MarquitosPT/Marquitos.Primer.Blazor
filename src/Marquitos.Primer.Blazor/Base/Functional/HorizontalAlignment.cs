namespace Marquitos.Primer.Blazor.Base.Functional
{
    public sealed record HorizontalAlignment
    {
        public string Value { get; }

        private HorizontalAlignment(string value)
        {
            Value = value;
        }

        public static readonly HorizontalAlignment Center = new ("center");
        public static readonly HorizontalAlignment Start = new ("flex-start");
        public static readonly HorizontalAlignment End = new ("flex-end");
        public static readonly HorizontalAlignment SpaceBetween = new ("space-between");
        public static readonly HorizontalAlignment SpaceAround = new ("space-around");
        public static readonly HorizontalAlignment SpaceEvenly = new ("space-evenly");

        public override string ToString() => Value;
    }
}

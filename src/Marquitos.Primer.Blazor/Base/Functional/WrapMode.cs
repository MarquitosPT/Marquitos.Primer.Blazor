namespace Marquitos.Primer.Blazor.Base.Functional
{
    public sealed record WrapMode
    {
        public string Value { get; }

        private WrapMode(string value)
        {
            Value = value;
        }

        public static readonly WrapMode Wrap = new ("wrap");
        public static readonly WrapMode NoWrap = new("nowrap");

        public override string ToString() => Value;
    }
}

namespace Marquitos.Primer.Blazor.Base.Functional
{
    public sealed record Direction
    {
        public string Value { get; }

        private Direction(string value)
        {
            Value = value;
        }

        public static readonly Direction Horizontal = new ("horizontal");
        public static readonly Direction Vertical = new("vertical");

        public override string ToString() => Value;
    }
}

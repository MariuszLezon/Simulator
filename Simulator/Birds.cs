using System;

namespace Simulator
{
    public class Birds : Animals
    {
        public bool CanFly { get; set; } = true;

        public override string Info => $"{Description} (fly{(CanFly ? "+" : "-")}) <{Size}>";

        public Birds() : base() { }
    }
}

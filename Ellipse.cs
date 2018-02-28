using System;

namespace ObjectOrientedDesign
{
    class Ellipse: Widget
    {
        public int DiameterH { get; }

        public int DiameterV { get; }

        public Ellipse(int x, int y, int diameterH, int diameterV) : base(x, y)
        {
            if (diameterH < 1 || diameterV < 1)
            {
                throw new ArgumentOutOfRangeException($"{nameof(diameterH)} and/or {nameof(diameterV)}","Diameters must be positive");
            }
            DiameterH = diameterH;
            DiameterV = diameterV;
        }
        
        public override void Draw() => Console.WriteLine(ToString());

        public override string ToString() => string.Format($"Ellipse ({Position.X},{Position.Y}) diameterH = {DiameterH} diameterV = {DiameterV}");
    }
}

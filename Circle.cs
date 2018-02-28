using System;

namespace ObjectOrientedDesign
{
    class Circle: Ellipse
    {
        public Circle(int x, int y, int diameter) : base(x, y, diameter, diameter){}
        
        public override void Draw() => Console.WriteLine(ToString());

        public override string ToString() => string.Format($"Circle ({Position.X},{Position.Y}) size={DiameterH}");
    }
}

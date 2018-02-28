using System;

namespace ObjectOrientedDesign
{
    class Square: Rectangle
    {
        public Square(int x, int y, int width) : base(x, y, width, width){}

        public override void Draw() => Console.WriteLine(ToString());

        public override string ToString() => string.Format($"Square ({Position.X},{Position.Y}) width={Width}");
    }
}

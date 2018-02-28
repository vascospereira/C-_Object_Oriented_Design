using System;

namespace ObjectOrientedDesign
{
    class Rectangle: Widget
    {
        public int Width { get; }

        public int Height { get; }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            if (width < 1 || height < 1)
            {
                throw new ArgumentOutOfRangeException($"{nameof(Width)} and/or {nameof(Height)}", "Widths and Heights must be positive");
            }
            Width = width;
            Height = height;
        }
        
        public override void Draw() => Console.WriteLine(ToString());

        public override string ToString() => string.Format($"Rectangle ({Position.X},{Position.Y}) width={Width} height={Height}");
    }
}

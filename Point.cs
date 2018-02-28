using System;

namespace ObjectOrientedDesign
{
    class Point
    {
        public int X { get; }

        public int Y { get; }

        public Point(int x, int y)
        {
            if (x < 1 || y < 1)
            {
                throw new ArgumentOutOfRangeException($"{nameof(X)} and {nameof(Y)}", "Coordinates must be positive");
            }
            X = x;
            Y = y;
        }
    }
}

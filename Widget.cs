namespace ObjectOrientedDesign
{
    abstract class Widget
    {
        public Point Position { get; }

        protected Widget(int x, int y) => Position = new Point(x, y);

        public abstract void Draw();
    }
}

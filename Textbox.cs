using System;

namespace ObjectOrientedDesign
{
    class Textbox: Rectangle
    {
        public string Text { get; }

        public Textbox(int x, int y, int width, int height, string text) : base(x, y, width, height) => Text = text;

        public override void Draw() => Console.WriteLine(ToString());

        public override string ToString() => string.Format($"Textbox ({Position.X},{Position.Y}) width={Width} height={Height} Text={Text}");
    }
}

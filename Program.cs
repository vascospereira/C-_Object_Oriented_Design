using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedDesign
{
    internal class Program
    {
        private static readonly List<Widget> Widgets = new List<Widget>();
       
        private static void Main()
        {
            try
            {
                CreateWigets();
                Print();
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        private static void CreateWigets()
        {
            Widgets.Add(new Rectangle(10, 10, 30, 40));
            Widgets.Add(new Square(15, 30, 35));
            Widgets.Add(new Ellipse(100, 150, 300, 200));
            Widgets.Add(new Circle(1, 1, 300));
            Widgets.Add(new Textbox(5, 5, 200, 100, "\"sample text\""));
        }

        private static void Print()
        {
            Console.WriteLine(Header());
            foreach (var widget in Widgets)
            {
                widget.Draw();
            }
            Console.WriteLine(Footer());
        }

        private static string Header()
        {
            var sb = new StringBuilder();
            sb.Append("----------------------------------------------------------------\n");
            sb.Append("Requested Drawing\n");
            sb.Append("----------------------------------------------------------------");
            return sb.ToString();
        }

        private static string Footer()
        {
            var sb = new StringBuilder();
            sb.Append("----------------------------------------------------------------");
            return sb.ToString();
        }
    }
}

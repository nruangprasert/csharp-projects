using System;
namespace Chapter05Question06
{
    internal class AreaApp
    {
        static void Main(string[] args)
        {
            char ch = ReceiveFigure();
            ProcessObject(ch);
            
            Console.ReadKey();
        }
        static char ReceiveFigure() 
        {
            Console.WriteLine("Please select a figure by using the following options: ");
            Console.WriteLine(@"Circle.......enter 'C'");
            Console.WriteLine(@"Rectangle....enter 'R'");
            Console.WriteLine(@"Cylinder.....enter 'Y'");
            Console.Write(@"Enter your choice here: ");
            char.TryParse(Console.ReadLine(), out char ch);
            return ch;
        }
        static void ReceiveC(char ch, out double radius)
        {
                Console.WriteLine("Please enter a value for the radius: ");
                double.TryParse(Console.ReadLine(), out radius);
        }
        static void ReceiveR(char ch, out double length, out double width)
        {
                Console.WriteLine("Please enter a value for the length: ");
                double.TryParse(Console.ReadLine(), out length);
                Console.WriteLine("Please enter a value for the width: ");
                double.TryParse(Console.ReadLine(), out width);
        }
        static void ReceiveY(char ch, out double radius, out double height)
        {
                Console.WriteLine("Please enter a value for the radius: ");
                double.TryParse(Console.ReadLine(), out radius);
                Console.WriteLine("Please enter a value for the height: ");
                double.TryParse(Console.ReadLine(), out height);
        }
        static void ProcessObject(char ch) 
        { 
            if (ch == 'c' || ch == 'C')
        {
            ReceiveC(ch, out double radius);
            Area area = new Area(ch, radius);
            Console.WriteLine(area);
        }
            else if (ch == 'r' || ch == 'R')
            {
            ReceiveR(ch, out double length, out double width);
            Area area = new Area(ch, length, width);
            Console.WriteLine(area);
            }
            else
            {
             string figure = "Cylinder";
            ReceiveY(ch, out double radius, out double height);
            Area area = new Area(ch, figure, radius, height);
            Console.WriteLine(area);
            }
        }
    }
}
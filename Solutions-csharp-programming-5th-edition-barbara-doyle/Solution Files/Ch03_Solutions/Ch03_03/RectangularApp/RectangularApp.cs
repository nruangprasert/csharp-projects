/*Rectangular.cs
 * This application allows users to input 
 * height and width of a rectangle.
 * It outputs the area and perimeter. Practice is
 * given writting and invoking methods.
 */

using System;
using static System.Console;

namespace RectangularApp
{
    class RectangularApp
    {
        static void Main( )
        {
            double  height,
                    width,
                    area,
                    perimeter;

            height = GetSize("Height");
            width = GetSize("Width");

            area = ComputeArea(height, width);
            perimeter = ComputePerimeter(height, width);
            DisplayResults(height, width, area, perimeter);
            ReadKey();
        }

        static double GetSize(string whichOne)
        {
            string inValue;
            double side;
            Write("Enter the {0}: ", whichOne);
            inValue = ReadLine();
            side = double.Parse(inValue);
            return side;
        }

        static double ComputeArea(double height, double width)
        {
            return height * width;
        }

        static double ComputePerimeter(double height, double width)
        {
            return 2 * height + 2 * width;
        }

        static void DisplayResults(double height, double width,
                                          double area, double perimeter)
        {
            Clear();
            WriteLine("Summary of Rectangle Measurments\n");
            WriteLine("{0, -12} {1,8:N1}", "Height:", height);
            WriteLine("{0, -12} {1,8:N1}", "Width:", width);
            WriteLine("{0, -12} {1,8:N1}", "Area:", area);
            WriteLine("{0, -12} {1,8:N1}", "Perimeter:", perimeter);
        }

    }
}

/*ComputeAreasFromInput.cs
 * This program displays a menu and
 * asks the user to make a figure selection. 
 * Once the figure is selected, additional
 * data is requested based on the selection. 
 * Using the dimensions entered, the area of
 * the figure will be calculated and displayed.
 */

using System;
using static System.Console;

namespace ComputeAreasFromInput
{
    class ComputeAreasFromInput
    {
        static void Main(string[] args)
        {
            string figure;
			double area;

            DisplayInstructions();
            figure = DisplayMenu(  );

            area = CreateShapes(figure);
			DisplayResults(figure, area);

            ReadKey();
		}

        static void DisplayInstructions( )
        {
            WriteLine("This application enables you to compute");
            WriteLine("different measurements for three figure types.");
            WriteLine("You will be asked to select a figure and then ");
            WriteLine("asked to enter it\'s unique measurement(s).");
            WriteLine("The area will be calculated and displayed.\n\n");
            WriteLine("Press any key when you are ready to begin....");
            ReadKey();
            Clear();
        }

        static string DisplayMenu(  )
		{
			char choice;
            string figureType,
                   inValue;
			Write("\nPlease select a figure by using the following options:\n" +
				  "\n\tCircle.......enter 'C'\n\t" +
				  "Rectangle....enter 'R'\n\t" +
				  "Cylinder.....enter 'Y'\n\n" +
				  "Enter your choice here: " );

            inValue = ReadLine();
			choice = char.Parse(inValue); 

			switch( choice )
			{
				case 'c':
				case 'C':
                    figureType = "Circle";
					break;
				case 'r':
				case 'R':
                    figureType = "Rectangle";
					break;
				case 'y':
				case 'Y':
                    figureType = "Cylinder";
					break;
				default:
                    figureType = "UNACCEPTABLE INPUT";
					break;
			}
			return figureType;
		}

   		public static double CreateShapes( string choice)
		{
            double area;
			if( choice == "Circle" )
			{
               area = CalculateAreaForCircle();
			}
			else 
                if (choice == "Rectangle" )
		        {
                      area = CalculateAreaForRectangle();
			    }
			    else
                    if (choice == "Cylinder")
                    {
                        area = CalculateAreaForCylinder();

                    }
                    else
                    {
                        WriteLine("\n********UNACCEPTABLE INPUT has been received.\n\n\n\n");
                        area = 0;
                    }
				return area;
			}

        public static double CalculateAreaForCircle()
        {
            double radius;
            PromptforInputValue("radius");
            if (double.TryParse(ReadLine(), out radius) == false)
                WriteLine("Invalid data entered - 0 recorded for radius");
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalculateAreaForRectangle()
        {
            double  length, 
                    width;
            PromptforInputValue("length");
            if (double.TryParse(ReadLine(), out length) == false)
                WriteLine("Invalid data entered - 0 recorded for length");
            PromptforInputValue("width");
            if (double.TryParse(ReadLine(), out width) == false)
                WriteLine("Invalid data entered - 0 recorded for width");
            return length * width;
        }

        public static double CalculateAreaForCylinder()
        {
            // S = 2prh + 2pr2
            double  radius, 
                    height;
            PromptforInputValue("height");            
            if (double.TryParse(ReadLine(), out height) == false)
                WriteLine("Invalid data entered - 0 recorded for height");
            PromptforInputValue("radius");
            if (double.TryParse(ReadLine(), out radius) == false)
                WriteLine("Invalid data entered - 0 recorded for radius");
            return 2 * Math.PI * radius * height + 2 * Math.PI * Math.Pow(radius, 2);
        }

        public static void PromptforInputValue(string what)
        {
            Write("\nPlease enter a value for the {0}: ", what);
        }

		public static void DisplayResults(string form, double area)
		{
			if( area > 0 )
			{
				WriteLine("\n\nThe area of a {0} with your " +
					"given dimensions is {1:N2} units.\n\n\n\n", form, area );
			}
		}
    }
}

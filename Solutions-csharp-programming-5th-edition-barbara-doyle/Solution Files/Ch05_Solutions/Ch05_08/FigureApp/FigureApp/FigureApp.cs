/*ClassCreationExercise.cs
 * This application contains four
 * classes. Three classes define types of objects. 
 * The fourth class is displays a menu of shapes,
 * instantiates the objects and displays the dimensions.
 */

using System;
using static System.Console;

namespace FigureApp
{
	class FigureApp
	{

		static void Main(string[] args)
		{
			string selection;

			DisplayInstructions();
			selection = DisplayMenu();
			CreateShape(selection);
			WriteLine("Press any key to see the next test...");
			ReadKey();

			Clear();
			selection = DisplayMenu();
			CreateShape(selection);
			WriteLine("Press any key to see the next test...");
			ReadKey();

			Clear();
			selection = DisplayMenu();
			CreateShape(selection);
			WriteLine("Press any key to see the next test...");
			ReadKey();

			Clear();
			selection = DisplayMenu();
			CreateShape(selection);
			WriteLine("Press any key to exit...");
			ReadKey();
		}

		static void DisplayInstructions()
		{
			WriteLine("This application performs computations for three types of figures.");
			WriteLine("\nFour (4) tests will be performed...");
			WriteLine();
			WriteLine("Unique calculations for each figure type will be shown.\n");
			WriteLine("You will be asked to select the figure and enter it\'s dimensions.");
			WriteLine("\n\nPress any key when you are ready to begin");
			ReadKey();
			Clear();
		}

		static string DisplayMenu()
		{
			string figureChosen;
			char choice;

			WriteLine("\nPlease select a figure by using the following options:\n");
			WriteLine("\tCIRCLE.......enter 'C'");
			WriteLine("\tRECTANGLE....enter 'R'");
			WriteLine("\tCYLINDER.....enter 'Y'");
			Write("Enter your choice here: ");
			if (char.TryParse(ReadLine(), out choice) == false)
			{
				Write("Please enter a single character (C, R, or Y): ");
				choice = char.Parse(ReadLine());
			}

			switch (choice)
			{
				case 'c':
				case 'C':
					figureChosen = "circle";
					break;
				case 'r':
				case 'R':
					figureChosen = "rectangle";
					break;
				case 'y':
				case 'Y':
					figureChosen = "cylinder";
					break;
				default:
					figureChosen = "UNACCEPTABLE INPUT";
					break;
			}
			return figureChosen;
		}

		public static void CreateShape(string selection)  //Solution could have char as parameter as opposed to string
		{
			Clear();
			if (selection == "circle")
			{
				Circle aCircle = new Circle();
				aCircle.Diameter = GetInput("Diameter");
				Clear();
				WriteLine(aCircle);
				WriteLine("Circumference: {0:F1}",  aCircle.CalculateCircumference());
			}
			else
				if (selection == "rectangle")
				{
					Rectangle aRect = new Rectangle();
					aRect.Length = GetInput("Length");
					aRect.Width = GetInput("Width"); ;
					Clear();
					WriteLine(aRect);
					WriteLine("Perimeter: " + aRect.CalculatePerimeter());
					WriteLine("Polygon Diagonal: {0:F1}", aRect.CalculatePolygonDiagonals());
				}
				else
					if (selection == "cylinder")
					{
						Cylinder aCyl = new Cylinder();
						aCyl.Height = GetInput("Height");
						aCyl.Radius = GetInput("Radius");
						Clear();
						WriteLine(aCyl);
						WriteLine("Curved Surface: {0:F1}", aCyl.CalculateCurvedSurfaceArea());
						WriteLine("Volumne: {0:F1}", aCyl.CalculateVolume());
					}
					else
						WriteLine(selection);
		}

		public static double GetInput(string whatValue)
		{
			double inputValue;
			Clear();
			Write("Please enter the {0}: ", whatValue);
			if (double.TryParse(ReadLine(), out inputValue) == false)
			{
				Write("Please enter a numeric value: ");
				inputValue = double.Parse(ReadLine());
			}
			return inputValue;
		}
	}
}


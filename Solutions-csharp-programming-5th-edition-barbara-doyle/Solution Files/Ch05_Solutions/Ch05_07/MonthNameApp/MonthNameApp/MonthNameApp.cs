/* MonthNameApp.cs
 * This application tests the MonthName class.
 * It asks for an integer between 1 and 12, then
 * instantiates an object of the MonthName class.
 * A call to the MonthName's ToString( ) method
 * displays the associated month and its
 * integral number of days.
 * 
 */

using System;
using static System.Console;

namespace MonthNameApp
{
    class MonthNameApp
    {
        static void Main(string[] args)
        {
            int monthNumber;

            Write("You will be asked to enter a number from 1 - 12. \nThe month associated with"
                + " the number will be displayed along with \nthe number of days in the month.\n\n");
            WriteLine("\n\nFor testing purposes, you will enter three (3) different test values.");

            WriteLine("\nPress any key when you are ready to begin...");
            ReadKey();
            Clear();

			monthNumber = GetInput( );
            MonthName firstTest = new MonthName(monthNumber);
            WriteLine(firstTest);

            WriteLine("\n\nPress any key when you are ready to do another test...");
            ReadKey();
            Clear();

            monthNumber = GetInput();
            MonthName secondTest = new MonthName(monthNumber);
            WriteLine(secondTest);

            WriteLine("\n\nPress any key when you are ready to do another test...");
            ReadKey();
            Clear();

            monthNumber = GetInput();
            MonthName thirdTest = new MonthName(monthNumber);
            WriteLine(thirdTest);

            ReadKey();
		}

		public static int GetInput( )
		{
            int inputNumber;
			Write( "Please enter an integer between 1 - 12 representing the month number: " );			
			if (int.TryParse(ReadLine(), out inputNumber) == false)
                WriteLine("Invalid month number entered - month set to 0");
			return inputNumber;			
		}

    }
}

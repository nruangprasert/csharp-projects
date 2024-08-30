/*RomanNumeralOutputApp.cs
 * This application test the RomanNumeralOutput
 * class. It allows users to enter a decimal value
 * between 1 and 10. The value is tested to
 * ensure it falls within the proper domain.
 * An object is instantiated and results
 * displayed.
 */
using System;
using static System.Console;

namespace RomanNumeralOutputApp
{
    class RomanNumeralOutputApp
    {
        static void Main(string[] args)
        {
            int inputValue;
            DisplayInstructions();

            RomanNumeralOutput firstTest = new RomanNumeralOutput(3);
            WriteLine(firstTest);
            WriteLine("\n\nPress any key for the next test...");

            ReadKey();
            //Clear();
            inputValue = GetInput();
            RomanNumeralOutput secondTest = new RomanNumeralOutput(inputValue);
            //Clear();
            WriteLine(secondTest);
            WriteLine("\n\nPress any key to see the next test...");

            ReadKey();
            //Clear();
            inputValue = GetInput();
            RomanNumeralOutput anotherTest = new RomanNumeralOutput(inputValue);
            WriteLine(anotherTest);
            ReadKey();
        }

        public static void DisplayInstructions()
        {
            WriteLine("\tRoman Numeral App");
            WriteLine("\n\nThis application allows decimal value between 1 and 10");
            WriteLine("to be entered. It displays the equivalent roman numeral value.");
            WriteLine("\n\nPress any key when you are ready to see the first test......");
            ReadKey();
            Clear();
        }

		public static int GetInput()
		{
			int val = 0;  // Note initilization is required because of the last if statement
			Clear();
			Write("Please enter a value between 1 and 10: ");
			if ((int.TryParse(ReadLine(), out val) == false) || val < 1 || val > 10)
			{
				WriteLine("\n\tPROBLEM WITH INPUT! \n\tYou've entered a non-numeric value ");
				WriteLine("\tOR the value entered was too large or too small");
				WriteLine("\tfor the data type.\n");
				Write("Please re-enter a value between 1 and 10: ");

				int.TryParse(ReadLine(), out val);
            }
			return val;
		}
	}
}

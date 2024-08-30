/* InputValidationLoop.cs
 * This program asks for positive integers
 * less than 100. Checks are included to make
 * sure the input values are in the 
 * given acceptable range.
 */

using System;
using static System.Console;

namespace InputValidationLoop
{
    class InputValidationLoop
    {
        static void Main( )
        {
            bool wantMoreData = true;
            bool validInput = true;
            int cntOfValidValues = 0;
            int cntOfInvalidValues = 0;
            int cntOfNonNumericCharacters = 0;
            int numInput = 0;
            string message = "";

            DisplayInstructions();

            while (wantMoreData)
            {
                numInput = PromptForNum(ref cntOfNonNumericCharacters);
                validInput = CheckValueRange(numInput);
                if (validInput == true)
                {
                    message = "ACCEPTABLE";
                    cntOfValidValues++;
                }
                else
                {
                    message = "UNACCEPTABLE";
                    cntOfInvalidValues++;
                }
                DisplayMessage(numInput, message);
                wantMoreData = PromptForMoreInput();
            }
            DisplayResults(cntOfValidValues, cntOfInvalidValues, cntOfNonNumericCharacters);
            ReadKey();
        }

        static void DisplayInstructions()
        {
            WriteLine("\n***   ***   ***   ***   ***   ***   ***   ***   ***  ***" +
                         "\n***   This application enables you to enter as many  ***" +
                         "\n***   values as you wish.... a test is performed to  ***" +
                         "\n***   ensure proper values are entered.              ***" +
                         "\n***   ***   ***   ***   ***   ***   ***   ***   ***  ***");
        }

        static bool PromptForMoreInput()
        {
            char input;
            bool choice;

            Write("\nWould you like to enter another value?" +
                        "\nPlease enter 'y' for yes or any other letter for no: ");
            if (char.TryParse(ReadLine(),  out input) == false) // In case they enter more than one character
                input = 'n';

            switch (input)
            {
                case 'y':
                case 'Y': choice = true;
                    break;
                default: choice = false;
                    break;
            }
            return choice;
        }

        static int PromptForNum(ref int cntOfNonNumericCharacters)
        {
            int numInput;
            string input = " 1 ";

            Clear();
            Write("Please enter a positive value less than 100: ");
            input = ReadLine();
            while (int.TryParse(input, out numInput) == false)
            {
                cntOfNonNumericCharacters++;
                WriteLine("Invalid character entered");
                Write("Please re-enter your value - (a positive value less than 100): ");
                input = ReadLine();
            }
            return numInput;
        }

        static bool CheckValueRange(int inValue)
        {
            bool inRange;
            if (inValue > 0)
                if (inValue < 100)
                    inRange = true;
                else
                    inRange = false;
            else
                inRange = false;
            return inRange;
        }

        static void DisplayMessage(int numIn, string outputString)
        {
            Clear();
            WriteLine("Value entered: {0} - {1} \n\n\n", numIn, outputString);
            if (outputString == "UNACCEPTABLE")
                WriteLine("Valid values are positive and less than 100.");
            WriteLine();
        }

        static void DisplayResults(int cntOfValidEntries, int cntOfInvalidEntries, int cntOfNonNumericCharacters)
        {
            Clear( );
            WriteLine("\tResults");
            WriteLine("Number of Valid values entered during testing: {0}", cntOfValidEntries);
            WriteLine("\nNumber of Invalid values entered: {0}", (cntOfInvalidEntries + cntOfNonNumericCharacters));            
            WriteLine("\tValues outside range: {0}", cntOfInvalidEntries);
            WriteLine("\tNon-numeric characters entered: {0}", cntOfNonNumericCharacters);

        }
    }
}
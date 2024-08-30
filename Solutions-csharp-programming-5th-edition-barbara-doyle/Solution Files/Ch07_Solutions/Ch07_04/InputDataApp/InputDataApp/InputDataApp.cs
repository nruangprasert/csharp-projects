/* InputDataApp.cs
 * This programs gets any number
 * between 0 and 10 from the user 
 * and stores it in an array. Also 
 * counts the number of times a certain value 
 * has been inputted.
 */
using System;
using System.Console;

namespace InputDataApp
{
    class InputDataApp
    {
        static void Main(string[] args)
        {
            int[] entries = new int[11];
            int cntOfInvalidEntries = 0;
            int numberOutsideRange = 0;

            DisplayInstructions();
            PrimeArray(entries);
            cntOfInvalidEntries = GetValues(entries, ref numberOutsideRange);
            DisplayResults(entries, cntOfInvalidEntries, numberOutsideRange);
            ReadKey();
        }

        public static void PrimeArray(int[] entries)
        {
            //initialize array with 0
            for (int i = 0; i < 11; i++)
            {
                entries[i] = 0;
            }
        }

        public static int GetValues(int [ ] entries, ref int numberOutsideRange)
        {
            int inValue;
            string stringInput; 
            bool moreInput = true;
            int cntOfInvalidEntries = 0;

            Clear();
            while (moreInput)
            {
                Write("\nInput any number between 0 and 10 (-1 to stop): ");
                stringInput = ReadLine();
                
                // Tests to to make sure an integer is entered
                while (int.TryParse(stringInput, out inValue) == false)
                {
                    Write("\nInvalid data type -" +
                            " value must be numeric between 0 and 10 (-1 to stop): ");
                    stringInput = ReadLine();
                    cntOfInvalidEntries++;
                }

                if (inValue == -1)
                    moreInput = false;
                else
                    if (inValue < -1 || inValue > 10)
                    {
                        Write("Invalid number - must be between 0 and 10 -  (-1 to stop): ");
                        numberOutsideRange++;
                    }
                    else
                        entries[inValue]++; // Uses array as an accumulator - adds one at the input value's location
            }
            return cntOfInvalidEntries;
        }

        public static void DisplayInstructions()
        {
            WriteLine("This application will allow you to enter any\n" +
                    "number of entries between 0 and 10.\n\n" +
                    "When you stop entering values, a message will\n" +
                    "display the values you entered along with the\n" +
                    "number of times it was entered.");
            WriteLine("\n\nTo stop entering values type -1\n");
            WriteLine("\n\n\n\nPress any key when you are ready to begin...");
            ReadKey( );
        }

        public static void DisplayResults(int[] entries, int cntOfInvalidEntries, int numberOutsideRange)
        {
            int cntOfValidEntries = 0;
            Clear( );
            WriteLine("\tInput Data App\n");
            WriteLine("{0,-12}{1,-6}", "InputValue", "Count");

            for (int x = 0; x < 11; x++)
            {
                if (entries[x] != 0)
                {
                    cntOfValidEntries  += entries[x];
                    WriteLine("{0,5}{1,10}", x, entries[x]);
                }
            }
            WriteLine("\nNumber of Valid Entries: {0}", cntOfValidEntries);

            WriteLine("\nNumber of Values Entered Outside Acceptable Range: {0}", numberOutsideRange);
            WriteLine("Number of Non-numeric Values Entered: {0}", cntOfInvalidEntries);
            WriteLine("Total Number of Inputs: {0}", (cntOfInvalidEntries + cntOfValidEntries + numberOutsideRange));

        }
    }
}

/* BarChartApp.cs
 * This programs allows users to input any number of integers
 * ranging in values from 0 to 10. A bar chart is created 
 * displaying an asterisk for each value entered.
 */

using System;
using System.Console;

namespace BarChartApp
{
    class BarChartApp
    {
        static void Main(string[] args)
        {
            int[] entries = new int[11];

            DisplayInstructions();
            PrimeArray(entries);
            CheckEntries(entries);
            DisplayResults(entries);
            Read();
        }

        public static void DisplayInstructions()
        {
            WriteLine("This application will allow you to enter any\n" +
                "number of entries between 0 and 10.\n\n" +
                "When you stop entering values, a frequency\n" +
                "distribution showing the number of times each\n" +
                "value was entered will be displayed.");
            WriteLine("\n\tTo stop entering values type -1\n");
            Write("\n\n\nPress any key when you are ready to begin...");
            ReadKey();
            Clear();
        }

        public static int GetValue()
        {
            int inValue;
            string stringVal;
           
            Write("Input any number between 0 and 10 (-1 to stop): ");
            stringVal = ReadLine();

            while (int.TryParse(stringVal, out inValue) == false)  // In case non-numeric data is entered 
            {
                Write("\nInvalid data - re-enter number [0 to 10] (-1 to stop): ");
                stringVal = ReadLine();
            }
            
            while (inValue < -1 || inValue > 10)
            {
                WriteLine("Invalid number");
                Write("Input any number between 0 and 10 -  (-1 to stop): ");
                stringVal = ReadLine();
                while (int.TryParse(stringVal, out inValue) == false)
                {
                    Write("\nInvalid data - re-enter number [0 to 10] (-1 to stop): ");
                    stringVal = ReadLine();
                }
            }
            return inValue;
        }

        public static void DisplayResults(int[] entries)
        {
            Clear();
            WriteLine("Frequency Distribution\n");
            for (int x = 0; x < entries.Length; x++)
            {
                Write("| {0}\t", x);
                if (entries[x] != 0)
                    for (int i = 0; i < entries[x]; i++)
                        Write("*");
                WriteLine();
            }
        }

        public static void PrimeArray(int[] entries)
        {
            //initialize array with 0
            for (int i = 0; i < entries.Length; i++)
            {
                entries[i] = 0;
            }
        }

        public static void CheckEntries(int[] entries)
        {
            int stop = 0;
            while (stop != -1)
            {
                stop = GetValue();
                if (stop != -1)
                    entries[stop]++;
            }
        }
    }
}



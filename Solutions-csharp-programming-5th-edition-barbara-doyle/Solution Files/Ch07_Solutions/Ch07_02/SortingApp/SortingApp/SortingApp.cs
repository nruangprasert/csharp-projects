/* SortingApp.cs	 
 * This program asks for names as input and
 * uses a predefined method of the Array
 * class to put the names in ascending order.
 * The results are displayed.
 */
using System;
using System.Console;


namespace SortingApp
{
    class SortingApp
    {
        static void Main( )
        {
            string[] namesInput = new string[100];
            int countOfNames;

            DisplayInformationAboutApp();
            countOfNames = PromptForInput(namesInput);
            DisplayResults(namesInput, countOfNames);          
            ReadKey();
        }

        public static void DisplayInformationAboutApp()
        {
            WriteLine("\t\t*******************" +
                "\n***You will be prompted to enter as many names   ***" +
                "\n***as you would like. The names will be sorted   ***" +
                "\n***and displayed in sort order.                  ***" +
                "\n****************************************************\n\n");
            WriteLine("\n\n\nPress any key when you are ready to begin...");
            ReadKey();
            Clear();
        }

        public static int PromptForInput(string[] namesInput)
        {
            string input;
            int countOfNames = 0;
            do
            {
                WriteLine("\nEnter Last Name-" +
                    "followed by a space then the First Name" +
                    "\n\tTo Exit, press the Enter key...");
                WriteLine();
                input = ReadLine();
                namesInput.SetValue(input, countOfNames);
                countOfNames++;
            } while (input != "");
            return countOfNames;
        }

        public static void DisplayResults(string[] namesIn, int countOfNames)
        {
            Clear();
            if (countOfNames > 1)
            {
                string[] actualLengthArray = new string[countOfNames];
                Array.Copy(namesIn, 0, actualLengthArray, 0, countOfNames);
                WriteLine("\nSorted Names");
                Array.Sort(actualLengthArray);

                foreach (string s in actualLengthArray)
                {
                    WriteLine(s);
                }
                WriteLine("\n");
            }
            else
                WriteLine("No names were entered");
        }
    }
}

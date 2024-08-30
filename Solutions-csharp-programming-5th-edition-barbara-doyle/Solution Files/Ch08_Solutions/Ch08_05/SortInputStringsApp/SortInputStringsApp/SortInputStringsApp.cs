/* SortInputStringsApp.cs	 
 * This program asks for names as input and
 * uses a predefined method of the Array
 * class to put the names inot ascending order.
 * The results are displayed.
 */
using System;
using static System.Console;

namespace SortInputStringsApp
{
    class SortInputStringsApp
    {
        static void Main(string[] args)
        {
            string[] namesInput = new string[100];
            string[,] lastNamesFirst;
            string[] finalArray;
            int countOfNames;

            DisplayInstructions();
            countOfNames = PromptForInput(namesInput);
            if (countOfNames > 0)
            {
                lastNamesFirst = StoreLastNameFirst(namesInput, countOfNames);
                finalArray = FormatArrayWithComma(lastNamesFirst);
                DisplayResults(finalArray);
            }
            ReadKey();
        }

        public static void DisplayInstructions()
        {
            WriteLine("******************************************************" +
                "\n***  You will be prompted to enter as many names   ***" +
                "\n***  as you would like. The names will be sorted   ***" +
                "\n***  and displayed in ascending order.             ***" +
                "\n******************************************************\n\n");
            Write("\n\n\n  Press any key when you are ready to begin...");
            ReadKey();
            Clear();
        }

        public static int PromptForInput(string[] namesInput)
        {
            string input;
            int countOfNames = 0;

            WriteLine("\n\t\tEnter a name \n(First Name-" +
                    "followed by a space then the middle initial" +
                    " and Last Name)..." +
                    "\n\tTo Exit, press the Enter key  ");
            input = ReadLine();
            while (input != "")
            {
                namesInput[countOfNames] = input;
                countOfNames++;
                WriteLine("\n\t\tEnter a name \n(First Name-" +
                    "followed by a space then the middle initial" +
                    " and Last Name)..." +
                    "\n\tTo Exit, press the Enter key  ");
                WriteLine();
                input = ReadLine();
            }
            return countOfNames;
        }

        public static string[,] StoreLastNameFirst(string[] namesInput,  int countOfNames)
        {
            string[] temp = new string[5];
            string[,] lastNamesFirst = new string[countOfNames, 3]; // Could eliminate countOfNames and use GetLength( ) method
 
            for (int row = 0; row < countOfNames; row++)
            {
                {
                    temp = namesInput[row].Split(' ');
                    if (temp.Length == 1) // Just one name entered
                    {
                        WriteLine("nadjldfjafjas;dsafd");
                        lastNamesFirst[row, 0] = temp[0];
                    }
                    else
                        if (temp.Length == 2)
                        {
                            lastNamesFirst[row, 0] = temp[1];
                            lastNamesFirst[row, 1] = temp[0];
                        }
                        else  // Middle initial entered
                        {
                            lastNamesFirst[row, 0] = temp[2];
                            lastNamesFirst[row, 1] = temp[0];
                            lastNamesFirst[row, 2] = temp[1];
                        }

                }
            }
            return lastNamesFirst;
        }

        public static string[ ] FormatArrayWithComma(string [, ] lastNamesFirst)
        {
            string [ ] newArray = new string [lastNamesFirst.GetLength(0)];

            for (int row = 0; row < lastNamesFirst.GetLength(0); row++)
            {
                if (lastNamesFirst[row, 1] == null)
                {
                    newArray[row] = lastNamesFirst[row, 0];
                }
                else
                {
                    for (int col = 0; col < lastNamesFirst.GetLength(1); col++)
                    {
                        newArray[row] += lastNamesFirst[row, col];
                        if (col == 0)
                            newArray[row] += ", ";
                        else
                            newArray[row] += " ";
                    }
                }

            }
           return newArray;
        }

        public static void DisplayResults(string[] finalArray)
        {
            Clear();
            ////If you wanted to keep the original names in the order they were entered,
            ////and create a new array, use the following code.
            //string[] actualLengthArray = new string[countOfNames];
            //Array.Copy(finalArray, 0, actualLengthArray, 0, countOfNames);
            //Array.Sort(actualLengthArray);

            WriteLine("Sorted Names\n------------\n");
            Array.Sort(finalArray);

            foreach (string s in finalArray)
            {
                WriteLine(s);
            }
        }
    }
}

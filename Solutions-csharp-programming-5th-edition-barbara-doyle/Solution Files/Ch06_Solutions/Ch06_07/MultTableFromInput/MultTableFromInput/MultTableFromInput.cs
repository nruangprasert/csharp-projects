/* MultTableFromInput.cs
 * This program asks for two
 * integers. It creates and 
 * displays a multiplication table
 * based on the integers entered.
 */

using System;
using static System.Console;

namespace MultTableFromInput
{
    class MultTableFromInput
    {
        static void Main( )
        {
            bool displayAnotherTable = true;
            int begBase,
                endBase;

            DisplayInfo();
            while (displayAnotherTable)
            {
                PromptForNums(out begBase, out endBase);
                DisplayTable(begBase, endBase);
                displayAnotherTable = PromptForMoreInput();
            }

            WriteLine("\n");
        }

        static void DisplayInfo()
        {
            WriteLine("\n***   You will be prompted to enter two integers.     ***" +
                      "\n***   A multiplication table will be displayed       ***" +
                      "\n***   based on these two base values entered.        ***" +
                      "\n***   Base values multipled from 1 through 25.       ***" +
                      "\n***   Enter as many sets of 2 bases as you like.     ***");
        }

        static bool PromptForMoreInput()
        {
            char input;
            bool choice;

            Write("\n***   Would you like to enter two base values? " +
                "\n***   Please enter 'y' for yes or any other letter for no: ");
            input = char.Parse(ReadLine());

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

        static void PromptForNums(out int begBase, out int endBase)
        {

            begBase = GetBaseEndPoint("first");
            while (begBase > 8 || begBase < 2)
            {
                begBase = GetBaseEndPoint("first");
            }

            endBase = GetBaseEndPoint("last");
            while (endBase > 8 || endBase < 2 )
            {
                endBase = GetBaseEndPoint("last");
               
            }

            while (endBase < begBase)
            {
                WriteLine("End base must be larger than or equal to beginning base value");
                endBase = GetBaseEndPoint("last");
            }
        }

        static int GetBaseEndPoint(string whichOne)
        {
            string inValue;
            int baseValue;
            Write("\nPlease enter the {0} base value, 2 - 8 :  ", whichOne);
            inValue = ReadLine();
            if (int.TryParse(inValue, out baseValue) == false)
                WriteLine("Invalid base entered - Please re-enter the value");
            return baseValue;
        }

        static void DisplayTable(int begBase, int endBase)
        {
            const int FIRST_COMPUTE_VALUE = 1;
            const int LAST_COMPUTED_VALUE = 25;

            Clear();
            Write("\n\n\n");
            Write("{0,3}" , "n");

            for (int i = begBase; i < endBase + 1; i++) // Produces Heading for the table
            {
                Write("{0,10}" , i);
            }

            Write("\n\n");

            for (int i = FIRST_COMPUTE_VALUE; i < LAST_COMPUTED_VALUE + 1; i++)
            {
                Write("{0,3}", i); // Displays 1 through 25 in the first column
                for (int j = begBase; j < endBase + 1; j++)
                {
                    Write("{0,10}",  i * j);
                }
                WriteLine();
            }
        }

    }
}

/* IsoscelesTriangleApp.cs
 * This program displays an isosceles triangle. The 
 * program asks for an input character to be used
 * for as the printing character. The program will
 * also request an input integer, between 1 and 10. 
 * The integer is used as the size of the triangle. 
 * Multiple inputs will be accepted.
 */

using System;
using static System.Console;

namespace IsoscelesTriangleApp
{
    class IsoscelesTriangleApp
    {
        static void Main( )
        {
            bool wantToPrint = true;
            char character = ' ';
            int number = 0;

            DisplayInfo();
            while (wantToPrint)
            {
                number = PromptForSize();
                character = PromptForCharacter();
                DisplayResults(character, number);
                wantToPrint = GetInput();
            }
            ReadKey();
        }

        static void DisplayInfo()
        {
            WriteLine("******************************************************************" +
                "\n****     You will be prompted to enter a character to be      ****" +
                "\n****     used for printing an isosceles triangle AND an       ****" +
                "\n****     integer between 1 and 10.                            ****" +
                "\n****     The integer will be the length for the two sides     ****" +
                "\n****     of the isosceles triangle. Whatever character is     ****" +
                "\n****     entered will be the character used for printing.     ****" +
                "\n\n****     You will be able to enter as many sets as you wish.  ****" +
                "\n******************************************************************");
            WriteLine("\n\n\tPress any key when you are ready to begin...");
            ReadKey();
            Clear();
        }

        static bool GetInput()
        {
            char input;
            bool choice;

            Write("\n\n\n\nWould you like to enter a new character and size? " +
                  "\nPlease enter 'y' for yes or any other letter for no:  ");
            if (char.TryParse(ReadLine(), out input) == false) // In case two characters are entered
            {
                WriteLine("Invalid data entered - No recorded for your response");
            }

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

        static int PromptForSize()
        {
            int number;
            Clear();
            WriteLine("How large of an isoceles Triange do you want to print? " );
            Write("Please enter a positive integer (between 1 and 10) :  ");
            if (int.TryParse(ReadLine(), out number) == false)
            {
                WriteLine("Invalid character entered - 3 will be stored for size");
                number = 3;
            }
            if (number > 10)
            {
                WriteLine("Invalid character entered - 3 will be stored for size");
                number = 3;
            }
            else
                if (number < 1)
                {
                    WriteLine("Invalid character entered - 3 will be stored for size");
                    number = 3;
                }
            return number;
        }

        static char PromptForCharacter()
        {
            char displayChar;
            Write("What character do you want to use for printing? ");
            if (char.TryParse(ReadLine(), out displayChar) == false)
            {
                WriteLine("Invalid character entered - An '*' will be used for printing");
                displayChar = '*';
            }
            return displayChar;
        }

        static void DisplayResults(char theCharacter, int triangleSize)
        {
            Clear();
            for (int i = 1; i < triangleSize + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Write(theCharacter);
                }
                WriteLine("\n");
            }

            for (int i = triangleSize; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Write(theCharacter);
                }
                WriteLine("\n");
            }
        }
    }
}

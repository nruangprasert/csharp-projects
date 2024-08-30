/* MessageDisplayApp.cs
 * This application allows users to input their
 * name and favorite saying. It then displays those values 
 * surrounded by <> symbols. Practice is given writing
 * and invoking methods.
 */

using System;
using static System.Console;

namespace MessageDisplayApp
{
    class MessageDisplayApp
    {
        static void Main( )
        {
            string name,
                   favoriteExpression;
            DisplayInstructions();
            name = GetInputValue("name");
            favoriteExpression = GetInputValue("favorite saying");
            DisplayNameAndSaying(name, favoriteExpression);
            ReadKey();
        }

        static void DisplayInstructions()
        {
            WriteLine("\tFavorite Saying Application\n\n" +
                      "You will be asked to enter both your name " +
                      "\nand favorite saying. The saying should be " +
                      "\nable to fit on one line and have fewer than " +
                      "\n50 characters. ");
            WriteLine("\nWhen you are ready to begin, press any key...");
            ReadKey();
            Clear();
        }

        static string GetInputValue(string whichValue)
        {
            string inputValue;
            Write("Please enter your {0}:  ", whichValue);
            inputValue = ReadLine();
            return inputValue;
        }

        static void DisplayNameAndSaying(string name, string favoriteExpression)
        {
            Clear();
            WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            WriteLine("\t{0}\'s Favorite Saying\n {1}", name, favoriteExpression);
            WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
        }
    }
}
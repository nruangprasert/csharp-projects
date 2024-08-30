/* MarkupApp.cs
 * This application allows an item wholesale price to be entered.
 * It shows the retail price of the item marked up at 5, 6, 7, 8, 9 and 10%. 
 * */

using System;
using static System.Console;

namespace MarkupApp
{
    class MarkupApp
    {
        static void Main( )
        {
            double itemPrice;
            DisplayInstructions();
            itemPrice = GetInput();
            ProduceTable(itemPrice);
            ReadKey();
        }

        static void DisplayInstructions()
        {
            WriteLine("********************************************");
            WriteLine("This application shows the retail price");
            WriteLine("of an item using different markup percentages.");
            WriteLine("\nYou will be asked to enter the wholesale price.");
            WriteLine("\n\n\nPress any key when you are ready to begin....");
            ReadKey();
        }

        static double GetInput()
        {
            double price;
            string inValue;

            Clear();
            Write("Please enter the wholesale price of the item: ");
            inValue = ReadLine();
            while (double.TryParse(inValue, out price) == false)
            {
                Write("\nInvalid data entered - " +
                                "Please re-enter the wholesale price of the item: ");
                inValue = ReadLine();

            }
            return price;
        }

        static void ProduceTable(double itemPrice)
        {
            PrintHeading();
            Write("{0,-10:C}", itemPrice);
            for (double percentage = 0.05; percentage < 0.10; percentage += 0.01)
            {
                Write("{0,10:C}", (itemPrice + (percentage * itemPrice)));
            }
        }

        static void PrintHeading()
        {            
            Clear();
            WriteLine("{0,-20} {1,25}", "Item", "Percentage Increase");
            Write("{0,-10}", "Price");

            for (double percentage = 0.05; percentage < 0.10; percentage += 0.01)
            {
                Write("{0,10:F2}", percentage);
            }
            WriteLine();
        }
    }
}


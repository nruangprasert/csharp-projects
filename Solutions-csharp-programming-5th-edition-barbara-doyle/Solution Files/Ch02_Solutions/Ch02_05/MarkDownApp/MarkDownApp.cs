/* MarkDownApp.cs
 * This application computes the retail price of items 
 * when there is a 15% sale. The original price, sale
 * price and savings are displayed. 
 */

using System;
using static System.Console;

namespace MarkDownApp
{
    class MarkDownApp
    {
        static void Main( )
        {
            const double MARK_DOWN = 0.15;
            string itemName = "Open Collar Running Shirt";
            double retailPrice = 41.00,
                   newPrice,
                   savingsExpected;

            newPrice = retailPrice - (retailPrice * MARK_DOWN);
            savingsExpected = retailPrice - newPrice;

            WriteLine("{0,14}\n", "Markup App");
            WriteLine("Item: {0}", itemName);
            WriteLine("Retail Price: {0,11:c}", retailPrice);
            WriteLine("Sales Price: {0,12:c}", newPrice);
            WriteLine("Savings Expected: {0,7:c}", savingsExpected);

            //Second item....same code as above with new values
            itemName = "Razorback T-Shirt";
            retailPrice = 36.00;

            newPrice = retailPrice - (retailPrice * MARK_DOWN);
            savingsExpected = retailPrice - newPrice;

            WriteLine("{0,14}\n", "Markup App");
            WriteLine("Item: {0}", itemName);
            WriteLine("Retail Price: {0,11:c}", retailPrice);
            WriteLine("Sales Price: {0,12:c}", newPrice);
            WriteLine("Savings Expected: {0,7:c}", savingsExpected);
            ReadKey();
        }
    }
}

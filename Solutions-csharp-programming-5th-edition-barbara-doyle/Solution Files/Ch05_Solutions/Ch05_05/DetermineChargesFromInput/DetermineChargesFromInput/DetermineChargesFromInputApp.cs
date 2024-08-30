/* DetermineChargesFromInputApp.cs
 * This application determines  shipping charges based on
 * the number of items purchased. Shippting charge per
 * items is reduced as the number of items purchased
 * increases. 
 */

using System;
using static System.Console;


namespace DetermineChargesFromInput
{
    class DetermineChargesFromInputApp
    {
        static void Main( )
        {
            int numberOfItemsPurchased;
            decimal shipCharge;
 
            Write("Shipping Charges Application\n\n");
            numberOfItemsPurchased = GetNumberOfItems();
            shipCharge = DetermineShipCharge(numberOfItemsPurchased);
            DisplayResults(numberOfItemsPurchased, shipCharge);

            ReadKey();
        }

        static int GetNumberOfItems()
        {
            int numOfItems;
            
            Write("\nPlease enter the number of items purchased: ");
            if (int.TryParse(ReadLine(), out numOfItems) == false)
                WriteLine("Problem with input - 0 recorded for number of items.");
            return numOfItems;
        }

        static decimal DetermineShipCharge(int numberOfItemsPurchased)
        {
            const decimal INITIAL_CHARGE = 2.99M;
            const decimal TWO_TO_FIVE_CHARGE = 1.99M;
            const decimal SIX_TO_FOURTEEN_CHARGE = 1.49M;
            const decimal MORE_THAN_FIFTEEN_CHARGE = 0.99M;
            
            decimal shipping;
            
            if (numberOfItemsPurchased > 14)
                shipping = INITIAL_CHARGE + (4 * TWO_TO_FIVE_CHARGE) + (9 * SIX_TO_FOURTEEN_CHARGE) + 
                    (MORE_THAN_FIFTEEN_CHARGE * (numberOfItemsPurchased - 15));
            else
                if (numberOfItemsPurchased > 5)
                    shipping = INITIAL_CHARGE + (4 * TWO_TO_FIVE_CHARGE) + 
                        (SIX_TO_FOURTEEN_CHARGE * (numberOfItemsPurchased - 5));
                else
                    if (numberOfItemsPurchased > 1)
                        shipping = INITIAL_CHARGE + 
                            (TWO_TO_FIVE_CHARGE * (numberOfItemsPurchased - 1));
                    else
                         shipping = INITIAL_CHARGE;
            return shipping;
        }

        static void DisplayResults(decimal numberOfItemsPurchased, decimal shipCharge)
        {
            Clear();
            Write("Shipping Charges Application\n\n");

            if (shipCharge == 0)
                WriteLine("Error incorrect input.");
            else
            {
                WriteLine("The shipping charge for " +
                          "{0:f0} item(s): {1:C}.",
                          numberOfItemsPurchased, shipCharge);
            }
        }
    }
}

/* PurchaseApp.cs
 * This program allows the user to enter any 
 * number of purchase amounts. It displays the 
 * total due including sales tax and
 * shipping charges.
 */

using System;
using static System.Console;

namespace PurchaseApp
{
    class PurchaseApp
    {
        static void Main( )
        {
			double  shippingCharge,
			        salesTax,
                    purchase,
                    cntOfPurchases = 0,
                    totalPurchases = 0;
			bool enterMorePurchases = true;
			string answer;

            DisplayInstructions();
            do 
			{
			    purchase = GetPurchaseAmount();
                if (purchase != 0)
                {
                    cntOfPurchases++;
                    totalPurchases += purchase;
                }
                Write("\n\nDo you want to enter more purchases? - Y or N ");
				answer = ReadLine();
				if(answer == "Y" || answer == "y")
					enterMorePurchases = true;
                else
                    enterMorePurchases = false;
            } while (enterMorePurchases);

            shippingCharge = CalculateShippingCharge(cntOfPurchases);
			salesTax = CalculateSalesTaxDue(totalPurchases);
            DisplayResults(totalPurchases, cntOfPurchases, shippingCharge, salesTax);
            ReadKey();
		}

        static void DisplayInstructions( )
        {
            WriteLine("This application computes the total due for your purchases.");
            WriteLine("It will allow you to enter any number of purchase amounts. ");
            WriteLine("When you are finished entering purchases, it displays the ");
            WriteLine("total due including sales tax and shipping charges.");
            WriteLine("\n\nPress any key when you are ready to begin...");
            ReadKey();
        }

		static double GetPurchaseAmount()
		{
            double purchase;

            Clear();
			Write("What is the amount of the item? ");
            while (double.TryParse(ReadLine(), out purchase) == false)
            {
                Write("\nInvalid data entered - " +
                                    "Please re-enter the amount of the item: ");
            }
			return purchase;
		}

		static double CalculateShippingCharge(double cntOfPurchases)
		{
            double shippingCharge;
			if (cntOfPurchases < 3)
				shippingCharge = 3.50;
			else 
                if(cntOfPurchases < 7)
                    shippingCharge = 5.00;
			    else 
                    if(cntOfPurchases < 11)
                        shippingCharge = 7.00;
			        else 
                        if(cntOfPurchases < 16)
                            shippingCharge = 9.00;
			            else
                            shippingCharge = 10.00;
            return shippingCharge;
		}

        static double CalculateSalesTaxDue(double totalPurchases)
        {
            const double TAX_RATE = 0.075;
            return totalPurchases * TAX_RATE;
        }

		static void DisplayResults(double purchases, double cntOfPurchases,
                                            double shipping, double salesTax)
		{
            Clear( );
			WriteLine("------------------------------------");
            WriteLine("\tSales Receipt");
			WriteLine("Total Purchases:	{0,10:C}", purchases);
            WriteLine("Sales Tax:		{0,10:C}", salesTax);
            WriteLine("Number of Items Purchased: {0,7}", cntOfPurchases);
            WriteLine("Shipping charge:	{0,10:C}", shipping);
	    	WriteLine("------------------------------------");
			WriteLine("Grand Total:		{0,10:C}", purchases + shipping + salesTax);
        }
    }
}

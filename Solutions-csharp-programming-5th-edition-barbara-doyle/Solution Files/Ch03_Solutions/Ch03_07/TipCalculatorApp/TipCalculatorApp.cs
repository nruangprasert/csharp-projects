/*TipCalculatorApp
 * this application determines the tip amount that 
 * should be added to a restaurant charge. The user is allowed 
 * to input the total, before taxes, and the tip percentage 
 * (15% or 20%). Output is produced showing the calculated 
 * values including the total amount due. 
 */

using System;
using static System.Console;

namespace TipCalculatorApp
{
    class TipCalculatorApp
    {
        static void Main( )
        {
            const double TAX = 0.09;
            const double SMALL_TIP = 0.15;
            const double LARGER_TIP = 0.20;

            double totalBeforeTaxesAndTip,
				   billWithTax,
                   smallTipAmount,
                   largerTipAmount,
                   taxAmount;

            totalBeforeTaxesAndTip = GetTotal();
            taxAmount = CalculateTaxDue(totalBeforeTaxesAndTip, TAX);
			billWithTax = CalculateBillWithTax(taxAmount, totalBeforeTaxesAndTip);
            smallTipAmount = CalculateTip(billWithTax, SMALL_TIP);
            largerTipAmount = CalculateTip(billWithTax, LARGER_TIP);
            DisplayTotals(totalBeforeTaxesAndTip, taxAmount, smallTipAmount, largerTipAmount, TAX,
                            SMALL_TIP, LARGER_TIP);
            ReadKey();
        }

        static double GetTotal()
        {
            string inValue;
            double total;
            Write("Please enter the total charges for the food purchases: ");
            inValue = ReadLine();
            total = double.Parse(inValue);
            return total;
        }

        static double CalculateTaxDue(double totalBeforeTaxesAndTip, double TAX)
        {
            return totalBeforeTaxesAndTip * TAX;
        }

		static double CalculateBillWithTax(double taxAmount, double totalBeforeTaxesAndTip)
        {
			return taxAmount + totalBeforeTaxesAndTip;
        }

        static double CalculateTip(double totalBeforeTaxesAndTip, double tip)
        {
            return totalBeforeTaxesAndTip * tip;
        }

        static void DisplayTotals(double totalBeforeTaxesAndTip, double taxAmount,
                                            double smallTipAmount, double largerTipAmount, double TAX,
                                            double SMALL_TIP, double LARGER_TIP)
        {
            Clear();
            WriteLine("\tTip Calculator App\n");
            WriteLine("{0,-26} {1,12:C}", "Total Before Taxes and Tip:", totalBeforeTaxesAndTip);
            WriteLine("{0,-4}({1,3:P0}): {2,29:C}", "Tax", TAX, taxAmount);
            WriteLine("\n{0,-4}({1,3:P0}): {2,28:C}", "Tip", SMALL_TIP, smallTipAmount);
            WriteLine("\n{0,40}", "--------");
            WriteLine("{0,-26} {1:P0} Tip: {2,15:C}", "Total Including Taxes with ", SMALL_TIP,
                                (totalBeforeTaxesAndTip + taxAmount + smallTipAmount));
            WriteLine("\n\n{0,-4}({1,3:P0}): {2,28:C}", "Tip", LARGER_TIP, largerTipAmount);
            WriteLine("\n{0,40}", "--------");

            WriteLine("{0,-26} {1:P0} Tip: {2,15:C}", "Total Including Taxes with ", LARGER_TIP,
                                (totalBeforeTaxesAndTip + taxAmount + largerTipAmount));
        }
    }
}

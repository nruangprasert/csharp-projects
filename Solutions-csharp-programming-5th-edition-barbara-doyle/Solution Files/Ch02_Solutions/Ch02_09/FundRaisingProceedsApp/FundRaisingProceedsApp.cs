/* CalculateFundRaisingProceedsApp.cs
 */

using System;
using static System.Console;

namespace FundRaisingProceedsApp
{
    class FundRaisingProceedsApp
    {
        static void Main( )
        {
            const double ASSOCIATION_FEE_RATE = 0.10;
            const int BARS_PER_CASE = 100;
            const double PRICE_PER_BAR = 1.5;
            const double WHOLESALE_COST_PER_CASE = 100.00;

            int casesSold,
                barsSold;
            double grossSales,
                   productCost,
                   grossProfit,
                   govtAssocFee,
                   netProfit;

            casesSold = 29;  // Value used for testing

            barsSold = casesSold * BARS_PER_CASE;
            grossSales = barsSold * PRICE_PER_BAR;
            productCost = casesSold * WHOLESALE_COST_PER_CASE;
            grossProfit = grossSales - productCost;
            govtAssocFee = grossProfit * ASSOCIATION_FEE_RATE;
            netProfit = grossProfit - govtAssocFee;

            WriteLine("{0,22}\n", "Granola Bar Sales");
            WriteLine("{0,-15} {1,10:N0}", "Cases Sold:", casesSold);
            WriteLine("{0, -15} {1,10:c}", "Gross Sales:", grossSales);
            WriteLine("{0, -15} {1,10:c}", "Product Costs:", productCost);
            WriteLine("{0, -15} {1,10:c}",  "SGA Fees:", govtAssocFee);
            WriteLine();
            WriteLine("{0, -15} {1,10:c}",  "Net Proceeds:", netProfit);

            ReadKey();
        }
    }
}

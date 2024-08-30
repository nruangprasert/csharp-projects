/* CalculateProfits.cs
 * This application computes the amount of money the computer club
 * will receive from proceeds of their granola bar sales. 10% of earnings
 * are furnished to SGA. Practice is given writing and invoking methods. */

using System;
using static System.Console;

namespace CalculateProfits
{
    class CalculateProfits
    {
        static void Main( )
        {
            const double WHOLESALE_COST_PER_CASE = 5.00;
            const int BARS_PER_CASE = 12;

            int barsSold;
            double pricePerBar,
                    casesSold,
                    grossSales,
                    netSales,
                    sgaFee,
                    netProfit;

            DisplayInstructions();
            pricePerBar = GetInfo("price per bar - i.e.  0.75");
            casesSold = GetInfo("number of cases sold");
            barsSold = CalculateBarsSold(casesSold, BARS_PER_CASE);
            grossSales = CalculateGrossSales(pricePerBar, barsSold);
            netSales = CalculateNetSales(casesSold, grossSales, WHOLESALE_COST_PER_CASE);
            sgaFee = CalculateSGAFeeDue(netSales);
            netProfit = CalculateNetProfit(netSales, sgaFee);
            DisplayResults(pricePerBar, casesSold, barsSold, grossSales,
                           netSales, sgaFee, netProfit, WHOLESALE_COST_PER_CASE,
                           BARS_PER_CASE);
            ReadKey();
        }

        static void DisplayInstructions()
        {
            Write("\nThis application shows how much is made on the granola sales project.\n" +
                            "First you will be asked to enter the sale price per bar.\n" +
                            "Then you will be asked to enter the number of cases of granola bars sold.\n\n" +
                            "The amount of profit made on the granola sales will be displayed.\n\n" +
                            "\t...Press any key when you are ready to begin...");
            ReadKey();
            Clear();
        }

        static double GetInfo(string wantedInfo)
        {
            string inputValue;
            double number;

            Write("\nPlease enter the {0}: ", wantedInfo);
            inputValue = ReadLine();
            number = double.Parse(inputValue);
            return number;
        }

        static int CalculateBarsSold(double casesSold, int BARS_PER_CASE)
        {
            return ((int)casesSold * BARS_PER_CASE);
        }

        static double CalculateGrossSales(double price, int barsSold)
        {
            return (price * barsSold);
        }

        static double CalculateNetSales(double casesSold, double grossSales,
                                double WHOLESALE_COST_PER_CASE)
        {
            return (grossSales - (casesSold * WHOLESALE_COST_PER_CASE));
        }

        static double CalculateSGAFeeDue(double netSales)
        {
            const double ASSOCIATION_FEE_RATE = 0.10;
            return (ASSOCIATION_FEE_RATE * netSales);
        }

        static double CalculateNetProfit(double netSales, double govtFeeDue)
        {
            return (netSales - govtFeeDue);
        }

        static void DisplayResults(double pricePerBar, double casesSold, int barsSold,
                                    double grossSales, double netSales,
                                    double sgaFee, double netProfit,
                                    double WHOLESALE_COST_PER_CASE,
                                    int BARS_PER_CASE)
        {
            Clear();
            WriteLine("{0,30}", "Summary of Candy Sales\n");
            WriteLine("{0,-25} {1,10:f0}", "Number of Cases Sold:", casesSold);
            WriteLine("{0,-25} {1,10:f0}", "Number of Bars Per Case:", BARS_PER_CASE);
            WriteLine("{0,-25} {1,10:f0}", "Number of Bars Sold:", barsSold);
            WriteLine();
            WriteLine("{0,-25} {1,10:f2}", "Wholesale Cost Per Bar:", WHOLESALE_COST_PER_CASE / BARS_PER_CASE);
            WriteLine("{0,-25} {1,10:f2}", "Selling Price Per Bar:", pricePerBar);

            WriteLine();
            WriteLine("{0,-25} {1,10:f2}", "Gross Sales:", grossSales);
            WriteLine("{0,-25} {1,10:f2}", "Cost of Candy:", WHOLESALE_COST_PER_CASE * casesSold);
            WriteLine("{0,-25} {1,10:f2}", "Net Sales:", netSales);
            WriteLine("{0,-25} {1,10:f2}", "SGA Fee:", sgaFee);
            WriteLine("\n\n{0,-25} {1,10:c}*", "******Profit:", netProfit);
        }
    }
}

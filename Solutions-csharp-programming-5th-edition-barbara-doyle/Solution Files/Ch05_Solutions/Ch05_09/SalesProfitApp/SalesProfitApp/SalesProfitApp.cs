/* SalesProfitApp.cs
 * This application determines
 * profits from sales. Profit ratio
 * is based on the total amount of
 * sales. The application allows the user
 * to input sales. It calculates profit due, 
 * and displays the amounts formatted.
 */

using System;
using static System.Console;

namespace SalesProfitApp
{
    class SalesProfitApp
    {
        public static void Main(string[] args)
        {
             decimal sales,
                    profitRatio, 
                    profit;		
		
            Write("\tSales Profit App\n");
            sales = GetInput( );
			profitRatio = GetProfitRatioRate(sales);
			profit = CalculateProfit(sales, profitRatio);			
			DisplayResults(sales, profit, profitRatio);
            ReadKey();
		}

		public static decimal GetInput( )
		{
			decimal gross;
            Write("\nPlease enter sales amount: ");			 
			gross = decimal.Parse(ReadLine() );
			return gross;
		}

		public static decimal GetProfitRatioRate(decimal sales)
		{
            decimal rate; 
            if(sales > 10000m)
			{
				rate = 0.045m;
			}
			else 
                if(sales > 5000m)
			    {
				    rate = 0.04m;
			    }
                else 
                    if(sales > 1000m)
			        {
				        rate = 0.035m;
			        }
			        else 
                        if( sales > 0m )
			            {
				            rate = 0.03m;
			            }
			            else
			            {
				            rate = 0.00m;
			            }			
			return rate;
		}

		public static decimal CalculateProfit(decimal grossPay, decimal rate)
		{
			return grossPay * rate;
		}
		
		public static void DisplayResults(decimal gross, decimal profit, decimal rate)
		{
            Clear();
			if( profit == 0 )
			{
				WriteLine("\n*******UNACCEPTABLE INPUT was received.*******\n\n\n\n" );
			}
			else
			{
                Write("\tSales Profit App\n");
				WriteLine("\nSales: {0:c} \nProfit Ratio: {1:p} \nNet Proceeds: {2:c}",
					               gross, rate, profit);
			}
        }
    }
}

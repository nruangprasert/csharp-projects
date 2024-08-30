/* SalesApp.cs
 * This application tallies sales for two salesmen 
 * selling three different products.  Sales are input by 
 * the user. Any number of sales can be entered.
*/
using System;
using static System.Console;

namespace SalesApp
{
    class SalesApp
    {
        static void Main(string[] args)
        {
            double[,] sales = new double[6, 3];
            string[] salesmenName = { "Jamaal Avery", "Amanda Davidson", "Bob Murphey", "Jim Saylor", "Choo Wang", "Lonna Young" };
            string[] productName = { "Tablets", "Phones", "Watches" };

            InitializeArray(sales);
            GetSalesFigures(sales, salesmenName, productName);
            DisplayResults(sales, salesmenName, productName);
            ReadKey();

        }
        public static void InitializeArray(double[,] sales)
        {
            for (int row = 0; row < sales.GetLength(0); row++)
                for (int col = 0; col < sales.GetLength(1); col++)
                    sales[row, col] = 0;
        }

        public static void GetSalesFigures(double[,] sales, string[] salesmenName, string[] productName)
        {

            int salesNo,
                productNo;
            string inputValue;
            bool moreData = true;
            while (moreData)
            {
                salesNo = GetSalesNumber(salesmenName);
                productNo = GetProductNumber(productName);
                sales[salesNo, productNo] += GetSalesFigures();
                Write("Are there more sales? (y/n)");
                inputValue = ReadLine();
                switch (inputValue)
                {
                    case "n":
                    case "N":
                        moreData = false;
                        break;
                    default:
                        moreData = true;
                        break;
                }
            }
        }

        public static int GetSalesNumber(string[] salesmenName)
        {
            int salesNo = -1;
            while (salesNo > salesmenName.Length || salesNo < 1)
            {
                Clear();
                WriteLine("Sales Registry\n\n");
				for (int i = 0; i < salesmenName.Length; i++)
				{
					WriteLine("{0}. {1}", (i + 1), salesmenName[i]);

				}
                Write("\nSales are for which salesman?  ");
                while (int.TryParse(ReadLine(), out salesNo) == false)
                {
                    Write("\n\n\tInvalid entry - Please enter a numeric value: ");
                }
            }
            return salesNo - 1;
        }

        public static int GetProductNumber(string[] productName)
        {
            int productNo = -1;
            while (productNo > 5 || productNo < 1)
            {
                Clear();
                WriteLine("Products\n\n");
				for (int i = 0; i < productName.Length; i++)
				{
					WriteLine("{0}. {1}", (i + 1), productName[i]);
				}

                Write("\nSales are for which product?  ");
                while (int.TryParse(ReadLine(), out productNo) == false)
                {
                    Write("\n\n\tInvalid entry - Please enter a numeric value: ");
                }
            }
            return productNo - 1;
        }

        public static double GetSalesFigures()
        {
            double salesAmt; 
            Write("What was the sales amount? ");
            while (double.TryParse(ReadLine(), out salesAmt) == false)
            {
                Write("\n\n\tInvalid entry - Please enter a numeric value: ");
            }
                return salesAmt;
        }

        public static void DisplayResults(double[,] sales, string[] salesmenName, string[] productName)
        {
            Clear();
            WriteLine("\t\tSales Summary\n\n");
            Write("{0, -15}", "Salesman Name");
            for (int i = 0; i < productName.Length; i++)
            {
                Write("{0, 10}", productName[i]);
            }
            WriteLine();
            for (int row = 0; row < sales.GetLength(0); row++)
            {
                Write("{0, -15}", salesmenName[row]);
                for (int col = 0; col < sales.GetLength(1); col++)
                {
                    Write("{0,10:N2}", sales[row, col]);
                }
                WriteLine();
            }
        }
    }
}

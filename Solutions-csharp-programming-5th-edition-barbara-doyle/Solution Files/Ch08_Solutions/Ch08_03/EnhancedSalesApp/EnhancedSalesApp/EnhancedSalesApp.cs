/* EnhancedSalesApp.cs
 * This application tallies sales for six salesmen 
 * selling three different products.  Sales are input by 
 * the user. Any number of sales can be entered. The total
 * amount sold per salesman is displayed and the largest
 * sales figure along with which salesman and which product
 * the sale is associated with are displayed. 
 * For the final display, the last name only of the 
 * salesman is displayed.  
*/
using System;
using static System.Console;

namespace EnhancedSalesApp
{
    class EnhancedSalesApp
    {
        static void Main(string[] args)
        {
            double[,] sales = new double[6, 3];
            string[] salesmanName = { "Jamaal Avery", "Amanda Davidson", "Bob Murphey", "Jim Saylor", "Choo Wang", "Lonna Young" };
            string[] productName = { "Tablets", "Phones", "Watches" };

            InitializeArray(sales);
            GetSalesFigures(sales, salesmanName, productName);
            DisplayTable(sales, salesmanName, productName);
            DisplayLargestSale(sales, salesmanName, productName);
            ReadKey();
        }

        public static void InitializeArray(double[,] sales)
        {
            for (int row = 0; row < sales.GetLength(0); row++)
                for (int col = 0; col < sales.GetLength(1); col++)
                    sales[row, col] = 0;
        }

        public static void GetSalesFigures(double[,] sales, string[] salesmanName, string[] productName)
        {
            int salesNo,
                productNo;
            string inputValue;
            bool moreData = true;
            while (moreData)
            {
                salesNo = GetSalesNumber(salesmanName);
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

        public static int GetSalesNumber(string[] salesmanName)
        {
            int salesNo = -1;
            while (salesNo > salesmanName.Length || salesNo < 1)
            {
                Clear();
                WriteLine("Sales Registry\n\n");
                for (int row = 0; row < salesmanName.Length; row++)
                {
                    WriteLine("{0}. {1}", row + 1, salesmanName[row]);
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
            while (productNo > 3 || productNo < 1)
            {
                Clear();
                WriteLine("Products\n\n");
                WriteLine("1. {0}", productName[0]);
                WriteLine("2. {0}", productName[1]);
                WriteLine("3. {0}", productName[2]);
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

        public static void DisplayTable(double[,] sales, string[] salesmanName, string[] productName)
        {
            double total;
            string[] name = new string[2];

            Clear();
            WriteLine("\t\tSales Summary\n\n");
            Write("{0, -15}", "Salesman Name");
            for (int i = 0; i < productName.Length; i++)
            {
                Write("  {0, -9}", productName[i]);
            }
            WriteLine("{0, -8}", "Total");
            for (int row = 0; row < sales.GetLength(0); row++)
            {
                name = salesmanName[row].Split(' ');
                Write("{0, -15}", name[1]);
                for (int col = 0; col < sales.GetLength(1); col++)
                {
                    Write("{0,10:N2}", sales[row, col]);
                }
                total = CalculateTotal(sales, row);
                WriteLine("{0,8:N2}", total);
            }
        }
        public static double CalculateTotal(double[,] sales, int row)
        {
            double total = 0;

            for (int col = 0; col < sales.GetLength(1); col++)
            {
                total += sales[row, col];
            }
            return total;
        }
        public static void DisplayLargestSale(double[,] sales, string[] salesmanName, string[] productName)
        {
            int largestRow = 0,
                largestCol = 0;

            FindLargestSale(sales, ref largestRow, ref largestCol);
            WriteLine();
            WriteLine("Largest Sales: " + sales[largestRow, largestCol].ToString("C"));
            WriteLine("Top Saleman: " + salesmanName[largestRow]);
            WriteLine("Top Product: " + productName[largestCol]);
        }

        public static void FindLargestSale(double[,] sales, ref int largestRow, ref int largestCol)
        {
            for (int row = 0; row < sales.GetLength(0); row++)
            {
                for (int col = 0; col < sales.GetLength(1); col++)
                {
                    if (sales[row, col] > sales[largestRow, largestCol])
                    {
                        largestRow = row;
                        largestCol = col;
                    }
                }
            }

        }
    }
}
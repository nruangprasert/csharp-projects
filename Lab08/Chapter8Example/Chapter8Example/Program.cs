using System;

namespace Chapter8Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] salesman = new string[4];
            double[,] sales = new double[4,5];
            GetSalesData(salesman, sales);
            Console.WriteLine(sales[0, 0]);
            Console.WriteLine(sales[1, 0]);
            Console.WriteLine(sales[2, 0]);
            Console.WriteLine(sales[3, 0]);
            ProduceSalesProjectionTable(sales);
            DisplaySalesProjections(salesman, sales);
            Console.ReadKey();

        }
        public static void GetSalesData(string[] salesman, double[,] sales)
        {
            for (int row = 0;  row < salesman.Length; row++)
            {
                string nameInput;
                string[] nameSplit = new string[2];
                Console.Write("Enter first name space last name : ");
                nameInput = Console.ReadLine();
                salesman[row] = nameInput;
                nameSplit = salesman[row].Split(' ');
                double salesInput = 0;
                Console.Write("Enter initial sales data of {0}: ", nameSplit[0]);
                double.TryParse(Console.ReadLine(), out salesInput);
                sales[row, 0] = salesInput;
            }
        }
        public static void ProduceSalesProjectionTable(double [,] sales)
        {
            for ( int row = 0; row < sales.GetLength(0); row++)
            {
                double salesIncrease = 0.05;
                for( int col = 1; col < sales.GetLength(1); col++)
                {
                    sales[row,col] = sales[row, col - 1] * salesIncrease + sales[row, col - 1];
                    salesIncrease += 0.05;
                }
            }
        }
        public static void DisplaySalesProjections(string[] salesman, double[,] sales)
        {
            for ( int row = 0;row < salesman.GetLength(0);row++) 
            {
                string[] nameSplit = salesman[row].Split(' ');
                Console.WriteLine();
                Console.Write($"{nameSplit[1]}" + "," + $"{nameSplit[0]}\t\t");
                for (int col = 1;col < sales.GetLength(1);col++)
                {
                    Console.Write($"{sales[row,col]}\t\t");
                }
            
            }


        }
    }
}

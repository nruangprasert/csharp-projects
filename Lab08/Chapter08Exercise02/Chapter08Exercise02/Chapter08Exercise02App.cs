using Microsoft.Win32;
using System;

namespace Chapter08Exercise02
{
    internal class Chapter08Exercise02App
    {
        static void Main(string[] args)
        {
            string[] salesRegistry = new string[6] { "1. Jamaal Avery", "2. Amanda Davidson", "3. Bob Murphey", "4. Jim Saylor", "5. Choo Wang", "6. Lonna Young" };
            string[] products = new string[3] { "1. Tablets", "2. Phones", "3. Watches"};
            double[,] display = new double[6, 3];
            bool moreSales = true;

            do 
            {
                Console.WriteLine("Sales Registry");
                for (int i = 0; i < salesRegistry.Length; i++)
                {
                    Console.WriteLine(salesRegistry[i]);
                }
                Console.WriteLine();
                Console.Write("Sales are for which salesman?  ");
                int salesmanNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Products");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine(products[i]);
                }
                Console.Write("Sales are for which product?  ");
                int productNumber = int.Parse(Console.ReadLine());
                Console.Write("What was the sales amount? ");
                double salesAmount = int.Parse(Console.ReadLine());

                display[salesmanNumber - 1, productNumber - 1] = salesAmount;

                Console.Write("Are there more sales? (y/n) ");
                string inputMoreSales = Console.ReadLine().ToLower();
                if ( inputMoreSales == "y")
                {
                    moreSales = true;
                }
                else 
                {
                    moreSales = false;
                }
            }
            while (moreSales == true);

            for (int i = 0;i < display.GetLength(0);i++) 
            {
                for(int j = 0; j < display.GetLength(1);j++) 
                {
                    Console.Write($"{display[i,j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

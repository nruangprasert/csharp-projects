using System;

namespace Chapter08Exercise06
{
    internal class Chapter08Exercise06App
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows : ");
            int rowInput = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns : ");
            int colInput = int.Parse(Console.ReadLine());
            int[,] intArray = new int[rowInput, colInput];
            Random random = new Random();
            int maxValue = int.MinValue;
            int maxRow = int.MinValue;
            int maxCol = int.MinValue;
            for (int i = 0; i < intArray.GetLength(0); i++) 
            {
                for (int j = 0; j < intArray.GetLength(1); j++) 
                {
                    intArray[i, j] = random.Next(0, 100);
                    if (intArray[i, j] > maxValue) 
                    { 
                        maxValue = intArray[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }
            for (int i = 0;i < intArray.GetLength(0); i++) 
            {
                for (int j = 0;j < intArray.GetLength(1);j++) 
                {
                    Console.Write($"{intArray[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Max value in array = {maxValue}");
            Console.WriteLine($"index = Row index {maxRow} and Column index {maxCol}");


            Console.ReadKey();
        }
    }
}

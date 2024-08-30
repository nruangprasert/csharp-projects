using System;

namespace Chapter08Exercise01
{
    internal class Chapter08Exercise01App
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows for this 2-D array : ");
            int rowTwoDArray = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns for this 2-D array : ");
            int colTwoDArray = int.Parse(Console.ReadLine());
            string[] ourOneDArray = new string[rowTwoDArray*colTwoDArray];
            string[,] OurTwoDArray = new string[rowTwoDArray, colTwoDArray];
            int k = 0;
            for (int i = 0; i < rowTwoDArray; i++) 
            { 
                for (int j = 0; j < colTwoDArray; j++) 
                {
                    
                    Console.Write($"Enter element for row {i} column {j} of this 2-D array : ");
                    OurTwoDArray[i, j] = Console.ReadLine();
                    ourOneDArray[k] = OurTwoDArray[i, j];
                    k++;
                }
            }
            for (int i = 0; i < rowTwoDArray; i++)
            {
                for (int j = 0; j < colTwoDArray; j++)
                {

                    Console.Write($"{OurTwoDArray[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0;i < ourOneDArray.Length; i++)
            {
                Console.Write($"{ourOneDArray[i]}\t");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
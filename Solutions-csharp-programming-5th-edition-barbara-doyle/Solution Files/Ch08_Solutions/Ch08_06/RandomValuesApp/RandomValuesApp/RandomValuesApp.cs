/* RandomValuesApp.cs
 * This application fills a 5x4 two-dimensional array 
 * random numbers between the 0 and 100. It includes 
 * a method that returns the smallest value. The array
 * and the index where the smallest value is stored are
 * displayed.
 */
using System;
using static System.Console;

namespace RandomValuesApp
{
    class RandomValuesApp
    {
        static void Main(string[] args)
        {
            int[,] ranArray = new int[5, 4];
            int rowSize,
                colSize;

            GetSizeOfArray(out rowSize, out colSize);
            ranArray = new int[rowSize, colSize];
            FillArray(ranArray);
            DisplayTable(ranArray);
            DisplayLargestValue(ranArray);
            ReadKey();
        }

        public static void GetSizeOfArray(out int rowSize, out int colSize)
        {
            string inValue;
            Write("How many rows do you want to create? ");
            inValue = ReadLine();
            while (int.TryParse(inValue, out rowSize) == false)
            {
                Write("Value must be numeric ");
                inValue = ReadLine();
            }

            Write("How many columns do you want to create? ");
            inValue = ReadLine();
            while (int.TryParse(inValue, out colSize) == false)
            {
                Write("Value must be numeric ");
                inValue = ReadLine();
            }
        }

        public static void FillArray(int[,] ranArray)
        {
            Random ranValue = new Random();

            for (int row = 0; row < ranArray.GetLength(0); row++)
            {
                for (int col = 0; col < ranArray.GetLength(1); col++)
                {
                    ranArray[row, col] = ranValue.Next(0, 100);
                }
            }
        }

        public static void DisplayTable(int[,] ranArray)
        {
            Clear();
            WriteLine("Random Generated Values\n");
            Write("{0,-8}    ", "Col");  //Col labels
            for (int col = 0; col < ranArray.GetLength(1); col++)
            {
                Write("{0,8}",  (col + 1));
            }
            WriteLine();
            for (int row = 0; row < ranArray.GetLength(0); row++)
            {
                Write("Row {0,-8}", (row + 1));  //row labels3
                for (int col = 0; col < ranArray.GetLength(1); col++)
                {
                    Write("{0,8}", ranArray[row, col] );
                }
                WriteLine();
            }
        }

        public static void  DisplayLargestValue(int [ , ]ranArray)
        {
            int largestValue,
                largestRow = 0,
                largestCol = 0;
            largestValue = FindLargestValue(ranArray, ref largestRow, ref largestCol);
            WriteLine("\nLargest Value: {0}\nRow {1}\nCol {2}",
                                ranArray[largestRow, largestCol], (largestRow + 1), (largestCol + 1));
        }

        public static int FindLargestValue(int[,] ranArray, ref int smallRow, ref int smallCol)
        {

            for (int row = 0; row < ranArray.GetLength(0); row++)
            {
                for (int col = 0; col < ranArray.GetLength(1); col++)
                {
                    if (ranArray[row, col] > ranArray[smallRow, smallCol])
                    {
                        smallRow = row;
                        smallCol = col;
                    }
                }
            }
            return ranArray[smallRow, smallCol];
        }
    }
}

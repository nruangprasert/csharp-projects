/* OneDimArrayGeneratorApp.cs
 * This application creates and returns a one-dimensional array 
 * containing all the elements in the two-dimensional array. 
 * The values are stored in a row major format. 
*/
using System;
using static System.Console;

namespace OneDimArrayGeneratorApp
{
    class OneDimArrayGeneratorApp
    {
        static void Main(string[] args)
        {
            int[,] twoDimArray = { {45, 55, 88, 19, 71}, {88, 32, 98, 99, 11},
                                   {23, 78, 16, 67, 42}, {19, 82, 11, 19, 17}, 
                                   {99, 21, 63, 8, 1}, {62, 25, 81, 90, 41}, 
                                   {3, 87, 61, 36, 42}, {2, 51, 6, 12, 33}, 
                                   {91, 93, 36, 88, 28}, {82, 49, 23, 75, 25}, 
                                   {27, 35, 69, 78, 30}, {20, 91, 19, 29, 63} };
            int[] oneDimArray = new int[twoDimArray.Length];

            DisplayTwoDimArray(twoDimArray);
            StoreValues(twoDimArray, oneDimArray);
            DisplayOneDimArray(oneDimArray);
            ReadKey();

        }

        public static void DisplayTwoDimArray(int[,] twoDimArray)
        {
            WriteLine("\t\tOriginal Array");
            for (int row = 0; row < twoDimArray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDimArray.GetLength(1); col++)
                {
                    Write("{0, 8}", twoDimArray[row, col] );
                }
                WriteLine();
            }
        }

        public static void StoreValues(int[,] twoDimArray, int[] oneDimArray)
        {
            int i = 0;
            for (int row = 0; row < twoDimArray.GetLength(0); row++)
            {
                for (int col = 0; col < twoDimArray.GetLength(1); col++)
                {
                    oneDimArray[i] = twoDimArray[row, col];
                    i++;
                }
            }
        }

        public static void DisplayOneDimArray(int[] oneDimArray)
        {
            WriteLine("\n\nNew Array");
            for (int i = 0; i < oneDimArray.Length; i++)
            {
                WriteLine("{0,6}", oneDimArray[i]);
            }
        }
    }

}


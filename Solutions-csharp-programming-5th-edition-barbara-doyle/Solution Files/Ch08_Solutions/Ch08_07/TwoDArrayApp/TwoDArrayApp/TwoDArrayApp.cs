/* TwoDArrayApp.cs
 * This program generates 10 random number and stores them
 * in the first column of the array. Then it squares the 
 * first column and stores that number in the second 
 * column of the array.  Numbers from the array are displayed
 * in a messagebox using the Show() method.
 */

using System;
using System.Windows.Forms;

namespace TwoDArrayApp
{
    class TwoDArrayApp
    {
        static void Main(string[] args)
        {
            double[,] numberArray = new double[10, 2];

            SetArray(numberArray);
            DisplayResults(numberArray);
        }

        public static void SetArray(double[,] numberArray)
        {
            Random num = new Random();
            for (int r = 0; r < numberArray.GetLength(0); r++)
            {
                numberArray[r, 0] = num.Next(0, 100);
                numberArray[r, 1] = Math.Pow(numberArray[r, 0], 2);
            }
        }

        public static void DisplayResults(double[,] numberArray)
        {
            string msg = "";
            //create string to display to messagebox
            msg += "Random Values Squared\n" + "\nRandom\tNumber\n";
            msg += "Number    Squared\n";
            msg += "---------------------\n";
            for (int r = 0; r < numberArray.GetLength(0); r++)
            {
				msg += String.Format("{0,10}", numberArray[r, 0]) +
				String.Format("{0,14:N0}", numberArray[r, 1]) + "\n";
            }
            MessageBox.Show(msg, "Squared Values");
        }
    }
}

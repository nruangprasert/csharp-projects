/* ParallelArrayApp.cs
 * This application intializes two
 * arrays at compile time with values.
 * The product of the two
 * arrays are stored in a third
 * array. The contents of all three arrays
 * are displayed in a Windows MessageBox. 
 */

using System;
using System.Windows.Forms;

namespace ParallelArrayApp
{
    class ParallelArrayApp
    {
        static void Main( )
        {
            double [] array1 = new double[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			double [] array2 = new double[] {22, 32, 14, 54, 23, 71, 234, 63, 91, 11};
			double [] array3 = new double[Math.Max(array1.Length, array2.Length)];
			
			array3 = ProduceThirdArray(array1, array2);
			DisplayResults(array1, array2, array3);	 
            // Additional tests could be performed by varying the size of array1 and array2
		}

        // Method assumes the two arrays of not of the same size
		public static double [ ] ProduceThirdArray(double[] array1, double[] array2) 
		{
            double[] array3 = new double [Math.Max(array1.Length, array2.Length)];  // Make array 3 the size of the largest of the two arrays.
            int sizeOfSmallest;

            for (sizeOfSmallest = 0; sizeOfSmallest < Math.Min(array1.Length, array2.Length); sizeOfSmallest++)
			{
                array3[sizeOfSmallest] = array1[sizeOfSmallest] * array2[sizeOfSmallest];
			}

            if (array1.Length > array2.Length)
            {
                for (int i = sizeOfSmallest; i < array3.Length; i++)
                {
                    array3[i] = array1[i] * 1;
                }
            }
            else
                if (array2.Length > array1.Length)
                {
                    for (int i = sizeOfSmallest; i < array3.Length; i++)
                    {
                        array3[i] = array2[i] * 1;
                    }
                }
            return array3;
        }

		public static void DisplayResults(double[] array1, double[] array2, 
										double[] array3)
		{
			string output;
            int sizeOfSmallest;

			output = "Array1 *  Array2 = Array3\n\n";
            output += "Array1" + "\t" + "Array2" + "\t" + "Array3" + "\n";
			for(sizeOfSmallest = 0; sizeOfSmallest < Math.Min(array1.Length, array2.Length); sizeOfSmallest++)
			{
                output += array1[sizeOfSmallest] + "\t" + array2[sizeOfSmallest] + "\t" +
                    + array3[sizeOfSmallest] + "\n";
			}
            if (array1.Length > array2.Length)
            {
                for (int i = sizeOfSmallest; i < array3.Length; i++)
                {
                    output += array1[i] + "\t\t" + array3[i] + "\n";
                }
            }
            else
            {
                if (array2.Length > array1.Length)
                {
                    for (int i = sizeOfSmallest; i < array3.Length; i++)
                    {
                        output += "\t"+ array2[i] + "\t" + array3[i] + "\n";
                    }
                }
            }

			MessageBox.Show(output, "Parallel Arrays");
		}
	}
}

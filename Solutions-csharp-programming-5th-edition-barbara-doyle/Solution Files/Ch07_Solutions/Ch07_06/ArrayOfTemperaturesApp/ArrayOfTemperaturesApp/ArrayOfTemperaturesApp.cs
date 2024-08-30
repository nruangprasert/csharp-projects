/* ArrayOfTemperaturesApp.cs
 * This class is used to test the public members of the
 * TemperatureArray class.
 */
using System;
using System.Console;

namespace ArrayOfTemperaturesApp
{
    class ArrayOfTemperaturesApp
    {
        static void Main(string[] args)
        {
            int[] weekOne = { 87, 98, 78, 88, 79, 89, 92 };
            ArrayOfTemperatures tempTest = new ArrayOfTemperatures(weekOne);

            WriteLine("Average Temp: {0}", tempTest.ReturnAverage().ToString("F2"));
            WriteLine("Lowest Temp: {0}", tempTest.ReturnSmallest().ToString("F0"));
            WriteLine("Highest Temp: {0}", tempTest.ReturnLargest().ToString("F0"));
            WriteLine("Average Temp excluding Lowest: {0}", tempTest.ReturnAverageExcludingSmallest().ToString("F2"));
            WriteLine("Number of Days below {0}: {1}", 80, tempTest.ReturnDaysBelow(80));
            WriteLine("Press any key to see the final test...");
            ReadKey();
            Clear();
            WriteLine(tempTest);

            ReadKey();
        }
    }
}

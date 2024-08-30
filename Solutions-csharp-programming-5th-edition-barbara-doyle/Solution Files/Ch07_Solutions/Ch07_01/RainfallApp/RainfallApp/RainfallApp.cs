/* RainfallApp.cs
 * This application allows the user to input monthly rainfall 
 * amounts for one year. The mean is displayed. A table
 * is produced that shows the month name along with the 
 * rainfall amount and its variance from the mean.
*/
using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace RainfallApp
{
    class RainfallApp
    {
        static void Main(string[] args)
        {
            double[] rain = new double[12];
            string[] monthName = new string[12] { "January", "February", "March",
                                                  "April", "May", "June", "July",
                                                  "August", "September", "October",
                                                  "November","December"};

            DisplayInformationAboutApp();
            rain = GetRainfallAmounts(rain,monthName);
            ProduceReport(rain, monthName);
            ReadKey();
        }

        public static void DisplayInformationAboutApp()
        {
            WriteLine("This application allows you to enter monthly rainfall " +
                        "\namounts for one year. A table is produced that shows the" +
                        "\nmonth name along with the rainfall amount and its " +
                        "\nvariance from the mean.\n\n\n");
            Write("\n\n\n\tPress any key to begin...");
            ReadKey();
            Clear();
        }

        public static double[] GetRainfallAmounts(double [ ] rain, string [ ] monthName)
        {  
           string inValue;
           for (int i = 0; i <  rain.Length; i++)
           {
               Write("Please enter the rainfall amount for {0}: ", monthName[i]);
               inValue = ReadLine( );
               while (double.TryParse(inValue, out rain[i]) == false)
               {
                   WriteLine("\tInvalid Data - must be numeric");
                   inValue = ReadLine( );
               }
             }
           return rain;
        }

        public static void ProduceReport(double[] rainArray, string [ ] monthName)
        {
            double meanOfRainfall;

			meanOfRainfall = rainArray.Average();   // using System.Linq; needed for this method

			Clear();
			WriteLine("\t\tRainfall App");
			WriteLine("\nAverage rainfall: {0:F1}", meanOfRainfall);
			WriteLine("\n{0,-9} {1,9} {2, 8}", "Month", "Rainfall Amt.", "Variance");
			for (int i = 0; i < rainArray.Length; i++)
			{
				WriteLine("{0,-9} {1,9} {2,10}",
					monthName[i], rainArray[i], Math.Abs(rainArray[i] - meanOfRainfall).ToString("F1"));
			}
		}

    }
}

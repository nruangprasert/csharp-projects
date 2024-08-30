/* DistanceConverterApp.cs
 * This application converts miles into 
 * feet and kilometers.
 * It provides practice designing a
 * solution requiring research for the formulas.
 */

using System;
using static System.Console;

namespace DistanceConverterApp
{
    class DistanceConverterApp
    {
        static void Main( )
        {
            const int FEET_PER_MILE = 5280;
            const double MILES_TO_KILOMETER_CONVERSION_FACTOR = 1.6;

            double miles = 4.5;
            double  feet,
                    kilometer;

            feet = FEET_PER_MILE * miles;
            kilometer = miles * MILES_TO_KILOMETER_CONVERSION_FACTOR;

            WriteLine("\tDistance Converter App\n");
            WriteLine("Miles:  {0,12:N2}", miles);
            WriteLine("\n\tEquivalent Values");
            WriteLine("Feet:  {0,10:N0}", feet);
            WriteLine("Kilometers: {0,8:N2}", kilometer);
            ReadKey();
        }
    }
}

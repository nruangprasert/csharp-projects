/*MeterConverterApp.cs
 * This application allows the user
 * to input a metric value for meter. 
 * It displays the equivalent value in feet 
 * and inches. Practice is given writing and
 * invoking methods.
 */
using System;
using static System.Console;

namespace MeterConverterApp
{
    class MeterConverterApp
    {
        static void Main( )
        {
            double  meters,
                    inches;
            int feet;

            meters = GetMeters();
            inches = CalculateTotalInches(meters);
            feet = DetermineFeet(inches);
            inches = DetermineRemainingInches(inches, feet);
            DisplayResults(meters, feet, inches);
            ReadKey();
        }

        static double GetMeters()
        {
            string inValue;
            double meters;
            Write("Please enter a value for Meters: ");
            inValue = ReadLine();
            meters = double.Parse(inValue);
            return meters;
        }

        static double CalculateTotalInches(double meters)
        {
            const double METERS_CONVERSION_FACTOR = 39.37;
            return METERS_CONVERSION_FACTOR * meters;
        }

        static int DetermineFeet(double inches)
        {
            int feet;
            feet = (int)inches / 12;
            return feet;
        }

        static double DetermineRemainingInches(double inches, int feet)
        {
            return inches - (feet * 12);
        }

        static void DisplayResults(double meters, int feet, double inches)
        {
            Clear();
            WriteLine("Metric Meter to Feet/Inches Conversion App");
            WriteLine("\nMeters: {0:N0}", meters);
            WriteLine("\nEquivalent Measurement: \n{0:N0} Feet & {1:F1} Inches", feet, inches);
        }
    } 
}

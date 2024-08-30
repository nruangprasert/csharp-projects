/* ConvertAndDisplayTemps.cs 
 * This application converts Fahrenheit tempertures
 * to their equivalent Celsius value. The user is
 * asked to input the value and then both values
 * are displayed.
 */

using System;
using static System.Console;

namespace ConvertAndDisplayTempsApp
{
    class ConvertAndDisplayTempsApp
    {
        static void Main( )
        { 
            double fahrenhetTemperature,
                  celsiusTemperature;

            fahrenhetTemperature = GetFahrenheit();
            celsiusTemperature = ConvertToCelsius(fahrenhetTemperature);
            DisplayTemperatures(fahrenhetTemperature, celsiusTemperature);
            ReadKey();
        }

        static double GetFahrenheit()
        {
            string inputValue;
            double fahrenhetTemperature;

            Write("Enter Fahrenheit Temperature: ");
            inputValue = ReadLine();
            fahrenhetTemperature = double.Parse(inputValue);

            return (fahrenhetTemperature);
        }

        static double ConvertToCelsius(double fahrenheitTemperature)
        {
            return (5.0 / 9.0 * (fahrenheitTemperature - 32.0));
        }

        static void DisplayTemperatures(double inputValue, double convertedValue)
        {
            Clear();
            WriteLine("\tTemperature Converter App");
            WriteLine("Fahrenheit: {0,6:F0}", inputValue);
            WriteLine("Celsius: {0,9:F0}", convertedValue);
        }
    }
}

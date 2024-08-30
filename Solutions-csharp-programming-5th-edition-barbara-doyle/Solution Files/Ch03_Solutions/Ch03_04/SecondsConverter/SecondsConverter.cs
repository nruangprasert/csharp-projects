/* SecondsConverter.cs
 * This applicaton allows user to
 * enter total seconds. It
 * converts that value to an equivalent 
 * number of hours, minutes, and seconds.
 *  
 */

using System;
using static System.Console;

namespace SecondsConverter
{
    class SecondsConverter
    {
        static void Main( )
        {
            int totalSeconds,
                hours,
                minutes,
                remainingSeconds;

            totalSeconds = InputSeconds();

            hours = DetermineNumberHours(totalSeconds);
            remainingSeconds = DetermineRemainingSeconds(totalSeconds, 3600);
            minutes = DetermineNumberMinutes(remainingSeconds);
            remainingSeconds = DetermineRemainingSeconds(remainingSeconds, 60);

            DisplayResults(totalSeconds, hours, minutes, remainingSeconds);
            ReadKey();
        }

        static int InputSeconds()
        {
            string inValue;
            int seconds;
            Write("Enter the total seconds: ");
            inValue = ReadLine();
            seconds = int.Parse(inValue);
            return seconds;
        }
        
        static int DetermineNumberHours(int totalSeconds)
        {
            return totalSeconds / 3600;
        }

        static int DetermineRemainingSeconds(int totalSeconds, int divisor)
        {
            return totalSeconds % divisor;
        }

        static int DetermineNumberMinutes(int totalSeconds)
        {
            return totalSeconds / 60;
        }

        static void DisplayResults(int totalSeconds, int hours, int minutes,
                                            int seconds)
        {
            Clear();
            WriteLine("     Time Converter\n");
            WriteLine("Total\n{0,-10} {1,8:N0}", "Seconds:", totalSeconds);
            WriteLine();
            WriteLine("{0,-10} {1,8:N0}", "Hours:", hours);
            WriteLine("{0,-10} {1,8:N0}", "Minutes:", minutes);
            WriteLine("{0,-10} {1,8:N0}", "Seconds:", seconds);
        }
    }
}

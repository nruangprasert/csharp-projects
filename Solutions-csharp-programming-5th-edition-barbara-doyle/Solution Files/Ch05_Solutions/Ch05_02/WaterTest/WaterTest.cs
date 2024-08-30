/* WaterTest.cs
 * This application allows users to input the pH number 
 * of a pool. It displays the aquarium’s level
 * (acidic, neutral, or alkaline) and type of 
 * additive needed to level out the pH.
 */
using System;
using static System.Console;

namespace WaterTest
{
    class WaterTest
    {
        static void Main(string[] args)
        {
            double ph;
            string phLevel;

            DisplayInstructions();
            ph = GetInput();
            phLevel = TestpH(ph);
            DisplayResults(ph, phLevel);
            ReadKey();
        }

        public static void DisplayInstructions()
        {
            WriteLine("\tpH Water Tester App");
            WriteLine("\nThis application enables you to input a pH number.");
            WriteLine("It tests the value entered and displays the water\'s ");
            WriteLine("ph level (acidic, neutral, or alkaline)");
            WriteLine("\n\nPress any key when you are ready to begin...");
            ReadKey();
        }

        public static double GetInput()
        {
            double ph;

            Clear();
            Write("Please enter the ph number: ");
            if (double.TryParse(ReadLine(), out ph) == false)
            {
                WriteLine("Invalid data entered");
            }
            return ph;
        }

        public static string TestpH(double ph)
        {
            string result;
            if (ph > 14)
                result = "Invalid input - (Number entered too large)";
            else
                if (ph < 0)
                    result = "Invalid input - (Number entered too small)";
                else
                    if (ph < 7)
                        result = "Acidic - Requires bases";
                    else
                        if (ph > 7.8)
                            result = "Alkaline - Requires acid";
                        else
                            result = "Neutral";
            return result;
        }

        public static void DisplayResults(double ph, string phLevel)
        {
			if (ph != 0)
			{
				Clear();
				WriteLine("\tFish Tank ph Tester App");
				WriteLine("\n\npH: {0}", ph);
				WriteLine("pH Level: {0}", phLevel);
			}
        }
    }
}

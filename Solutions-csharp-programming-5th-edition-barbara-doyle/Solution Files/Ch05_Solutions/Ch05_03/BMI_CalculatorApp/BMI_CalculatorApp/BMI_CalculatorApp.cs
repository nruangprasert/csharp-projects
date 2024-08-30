/* BMI_CalculatorApp.cs
 * This application allows users to input their
 * Imperial formula is BMI = (weight in pounds * 703) / (height in inches squared)
 * Metric Imperial formula is BMI = weight in kilograms / (height in meters squared)
 * 
 */
using System;
using static System.Console;

namespace BMI_CalculatorApp
{
    class BMI_CalculatorApp
    {
        static void Main(string[] args)
        {
			int weight,
				heightInFeet,
				extraInches;
            BodyMassIndexCalculator firstTest = new BodyMassIndexCalculator(200, 5, 5);
            WriteLine(firstTest);
            WriteLine("\n\n\n\nPress any key to see the next test...");
            ReadKey();
            Clear();

            BodyMassIndexCalculator secondTest = new BodyMassIndexCalculator(74, 1.82);
            WriteLine(secondTest);
            ReadKey();

			WriteLine("\n\n\n\nPress any key to see the last test, with your characteristics...");
			ReadKey();
			Clear();
			weight = InputWeight();
			heightInFeet = InputHeight("feet");
			extraInches = InputHeight("inches");
			BodyMassIndexCalculator lastTest = new BodyMassIndexCalculator(weight, heightInFeet, extraInches);
			Clear();
			WriteLine(lastTest);
			ReadKey();
		}


		public static int InputWeight()
		{
			string inValue;
			int weight = 0;

			Write("Enter the weight: ");
			inValue = ReadLine();
			if (int.TryParse(inValue, out weight) == false)
			{
				WriteLine("Invalid data entered for weight!");
				WriteLine("Value must be a positve integer representing weight.");
                Write("Enter the weight: ");
				inValue = ReadLine();
				int.TryParse(inValue, out weight);
			}
			return weight;
		}

		public static int InputHeight(string feetOrInches)
		{
			string inValue;
			int height = 0;

			Write("Enter the {0} height: ", feetOrInches);
			inValue = ReadLine();
			if (int.TryParse(inValue, out height) == false)
			{
				WriteLine("Invalid data entered for weight!");
				WriteLine("Value must be a positve integer representing height.");
				Write("Enter the {0} height: ", feetOrInches);
				inValue = ReadLine();
				int.TryParse(inValue, out height);
			}
			return height;
		}

	}
}

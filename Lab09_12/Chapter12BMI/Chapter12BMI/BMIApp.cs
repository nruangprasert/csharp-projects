using System;

namespace Chapter12BMI
{
    internal class BMIApp
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your weight in kilograms: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Enter your height in centimeters: ");
                double height = double.Parse(Console.ReadLine());

                BMI bmiCalculator = new BMI(weight, height);
                double bmi = bmiCalculator.CalculateBMI();
                Console.WriteLine($"Your BMI is: {bmi}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}

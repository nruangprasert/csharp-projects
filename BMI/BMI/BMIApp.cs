using System;
namespace BMICalculator
{
    internal class BMIApp
    {
        static void Main(string[] args)
        {
            char ch = SelectMode();
            CreateObject(ch);
            Console.ReadKey();
        }
        static char SelectMode()
        {
            Console.Write("Press m for Metic or press i for Imperial : ");
            char.TryParse(Console.ReadLine(), out var ch);
            return ch;
        }
            
        static void CreateObject(char ch)
        { 
            if (ch == 'm')
            {
                double height = GetMetric("height");
                double weight = GetMetric("weight");
                BMI bmi01 = new BMI(height, weight);
                bmi01.CalculateBMI();
                Console.WriteLine(bmi01);
            }
            else if (ch == 'i')
            {
                double height = GetImperial("height");
                double weight = GetImperial("weight");
                BMI bmi01 = new BMI(height, weight, true);
                bmi01.CalculateBMI();
                Console.WriteLine(bmi01);
            }
        }
        static double GetMetric (string value)
        {
            string unit = string.Empty;
            if (value == "height")
            {
                unit = "in meters";
            }
            else if (value == "weight")
            {
                unit = "in kilograms";
            }
            Console.Write($"Enter your {value} {unit} : ");
            //double inputMetric;
            double.TryParse(Console.ReadLine(), out double inputMetric);
            return inputMetric;
        }
        static double GetImperial(string value)
        {
            string unit = string.Empty;
            if (value == "height")
            {
                unit = "in inches";
            }
            else if (value == "weight")
            {
                unit = "in pounds";
            }
            Console.Write($"Enter your {value} {unit} : ");
            double inputImperial;
            double.TryParse(Console.ReadLine(), out inputImperial);
            return inputImperial;
        }
    }
}

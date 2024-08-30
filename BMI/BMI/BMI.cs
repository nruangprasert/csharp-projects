using System;

namespace BMICalculator
{
    internal class BMI
    {
        private double heightMetric;
        private double weightMetric;
        private double heightImperial;
        private double weightImperial;
        private bool flagImperial = false;
        private string weightStatus;
        public BMI()
        {

        }
        public BMI (double heightMetric, double weightMetric)
        {
            this.heightMetric = heightMetric;
            this.weightMetric = weightMetric;
        }
        public BMI (double heightImperial, double weightImperial, bool flagImperial)
        {
            this.heightImperial = heightImperial;
            this.weightImperial = weightImperial;
            this.flagImperial = flagImperial;
        }
        public double CalculateBMI() 
        {
            if (!flagImperial) 
            {
                return weightMetric/Math.Pow(heightMetric , 2) ;
            }
            else
            {
                return (weightImperial / Math.Pow(heightImperial, 2))*703;
            }
        }
        public override string ToString()
        {
            if (CalculateBMI() >= 30) 
            {
                weightStatus = "Obese";
            }
            else if (CalculateBMI() >= 25 && CalculateBMI() <= 29.9) 
            {
                weightStatus = "Overweight";
            }
            else if (CalculateBMI() >= 18.5 && CalculateBMI() <= 24.9)
            {
                weightStatus = "Normal";
            }
            else 
            {
                weightStatus = "Underweight";
            }
            Console.WriteLine();

            if (!flagImperial) 
            {
                return String.Format("{0,20}", "BMI App") +
                    "\nWeight(kilograms) : " + weightMetric.ToString("N2") +
                    "\nHeight(meters) : " + heightMetric.ToString("N2") +
                    "\nBMI : " + CalculateBMI().ToString("N2") +
                    "\nWeight Status : " + weightStatus;
            }
            else 
            {
                return String.Format("{0,20}", "BMI App") +
                        "\nWeight(pounds) : " + weightImperial.ToString("N2") +
                        "\nHeight(inches) : " + heightImperial.ToString("N2") +
                        "\nBMI : " + CalculateBMI().ToString("N2") +
                        "\nWeight Status : " + weightStatus;
            }
        }
    }
}

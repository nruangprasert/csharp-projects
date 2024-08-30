using System;

namespace Chapter12BMI
{
    internal class BMI
    {
        // Data members (fields)
        private double weight;
        private double height;

        // Constructor
        public BMI(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
        }

        // Properties
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // CalculateBMI method
        public double CalculateBMI()
        {
            // Convert height from centimeters to meters
            double heightInMeters = height / 100;
            // Calculate BMI
            return weight / (heightInMeters * heightInMeters);
        }

        // ToString method
        public override string ToString()
        {
            return $"Weight: {weight} kg, Height: {height} cm";
        }
    }
}
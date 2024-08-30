using System;
namespace FigureApp
{
    class Circle
    {
        private double radius;
		private double diameter;
        public Circle()
        {
        }
        public Circle(double dm)
        {
			diameter = dm;
			radius = dm / 2.0;
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
		public double CalculateCircumference()
		{
			return Math.PI * 2*radius;
		}
        //Property definitions
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
		public double Diameter
		{
			get
			{
				return diameter;
			}
			set
			{
				diameter = value;
				//radius = diameter / 2.0;
			}
		}
		public override string ToString()
        {
            return "Circle" +
                   "\n\nRadius: " + radius +
                   "\nArea: " + CalculateArea().ToString("N2");
        }
    }
}
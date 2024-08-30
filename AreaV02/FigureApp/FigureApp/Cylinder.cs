/*Cylinder.cs
 * The cylinder class includes data members for
 * radius and height. It has an instance method
 * to calculate the area and a ToString( ) 
 * method that returns a string containing
 * the dimensions and area.
 */

using System;

namespace FigureApp
{
    class Cylinder
    {
        private double radius;
        private double height;

        public Cylinder()
        {

        }
        public Cylinder(double rad, double heigh)
        {
            radius = rad;
            height = heigh;
        }

        // Surface area of the side
 		public double CalculateCurvedSurfaceArea()
		{
			return 2 * Math.PI * radius * height;
		}

		// Top or bottom of cylinder is a circle
		public double CalculateTopOrBottomCircle()
		{
			return Math.PI * Math.Pow(radius, 2);
		}

		// Areas of top and bottom of both circles + Area of the side
		public double CalculateSurfaceAreaForClosedCylinder()
		{
			return CalculateCurvedSurfaceArea() +
				CalculateTopOrBottomCircle() +
				CalculateTopOrBottomCircle();     
		}

		public double CalculateVolume()
		{
			return Math.PI * Math.Pow(radius, 2) * height;
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
        //Property definitions
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public override string ToString()
        {
            return "Cylinder" +
                   "\n\nRadius: " + radius +
                   "\nHeight: " + height +
                   "\nSurface Area: " + CalculateSurfaceAreaForClosedCylinder().ToString("N2");
        }

    }
}

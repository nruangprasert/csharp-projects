/*Rectangle.cs
 * The rectangle class includes data members for
 * length and width. It has an instance method
 * to calculate the area and a ToString( ) 
 * method that returns a string containing
 * the dimensions and area.
 */
using System;

namespace FigureApp
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle()
        {

        }
        public Rectangle(double len, double wid)
        {
            length = len;
            width = wid;
        }

        //Property definitions
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        //Property definitions
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double CalculateArea()
        {
            return length * width;
        }

		public double CalculatePerimeter()
		{
			return 2 * length + 2 * width;
		}

		public double CalculatePolygonDiagonals()
		{
			return Math.Sqrt(Math.Pow(length, 2) + Math.Pow(width, 2));
		}

        public override string ToString()
        {
            return "Rectangle" +
                   "\n\nLength: " + length +
                   "\nWidth: " + width +
                   "\nArea: " + CalculateArea().ToString("N2");
        }

    }
}

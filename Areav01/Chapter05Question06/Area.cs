using System;
namespace Chapter05Question06
{
    internal class Area
    {
        private char ch;
        private string figure;
        private double radius;
        private double length;
        private double width;
        private double height;

        public Area() 
        { 
        }
        public Area(char ch, double radius)
        {
            this.ch = ch;
            this.radius = radius;
        }
        public Area(char ch, double length, double width)
        {
            this.ch = ch;
            this.length = length;
            this.width = width;
        }
        public Area(char ch, string figure, double radius, double height)
        {
            this.ch = ch;
            this.radius = radius;
            this.height = height;
            this.figure = figure;
        }
        public char Ch { get { return ch; } set { ch = value; } }
        public string Figure { get { return figure; } set {  figure = value; } } 
        public double Radius { get { return radius; } set { radius = value; } }
        public double Length { get { return length; } set { length = value; } }
        public double Width { get { return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }
        
        public double CalculateArea() 
        {
            if (ch == 'c' || ch == 'C') 
            {
                return Math.PI * Math.Pow(radius, 2);
            }
            else if (ch == 'r' || ch == 'R')
            {
                return length * width;
            }
            else 
            {
                return (2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2));
            }
        }
        public override string ToString()
        {
            return "The area is " + CalculateArea().ToString("N2");
        }
    }
}
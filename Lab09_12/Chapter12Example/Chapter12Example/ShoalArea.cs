using System;
using System.Diagnostics;

namespace Chapter12Example
{
    internal class ShoalArea
    {
        private string location;
        private string state;
        private double mileMarker;
        private double[] lowTideDepth;
        private double[] hiTideDepth;
        public ShoalArea()
        {
            lowTideDepth = new double[4];
            hiTideDepth = new double[4];
        }
        public ShoalArea(string loc, string st, double mile, double[] low, double[] hi)
        {
            location = loc;
            CheckStateOk(st);
            mileMarker = mile;
            lowTideDepth = low;
            hiTideDepth = hi;
        }
        public ShoalArea(string loc, string st, double mile)
        {
            location = loc;
            state = st;
            mileMarker = mile;
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public double MileMarker
        {
            get { return mileMarker; }
            set { mileMarker = value; }
        }
        public double[] LowTideDepth
        {
            get { return lowTideDepth; }
            set { lowTideDepth = value; }
        }
        public double[] HiTideDepth
        {
            get { return hiTideDepth; }
            set { hiTideDepth = value; }
        }
        public double CalculateAverageDepth(double[] depthArray)
        {
            double sum = 0;
            double avg;
            //try
            try
            {
                for (int i = 0; i < depthArray.Length; i++)
                {
                    sum += depthArray[i];
                }
                avg = sum / depthArray.Length;
            }
            //catch 
            catch (DivideByZeroException e)
            {
                avg = 0;
                Trace.WriteLine("Attempted to Divide by Zero" + "\nException Type: " + e.Message);
            }
            return avg;
        }
        //method to check state
        public void CheckStateOk(string st)
        {
            switch (st.ToUpper())
            {
                case "FL":
                case "GA":
                case "NC":
                case "SC":
                case "VA":
                    state = st.ToUpper();
                    break;
                default:
                    TestOfStateException ex = new TestOfStateException("State not Part of Atlantic ICW");
                    throw ex;
            }
        }
        public override string ToString()
        {
            return "Location: " + location +
            "\nState: " + state +
            "\nMile: " + mileMarker +
            "\nAverage Low Water Depth: " +
            CalculateAverageDepth(lowTideDepth).ToString("N2") +
            "\nAverage High Water Depth: " +
            CalculateAverageDepth(hiTideDepth).ToString("N2") +
            "\n\nOverall Average Water Depth: " +
            ((CalculateAverageDepth(lowTideDepth) + CalculateAverageDepth(hiTideDepth)) / 2.0).ToString("N2");
        }
    }
}
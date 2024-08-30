/* ArrayOfTemperatures.cs
 * This class has a one-dimensional array as a data member that stores 
 * temperatures for any given week. It includes methods to return the 
 * highest temperature, lowest temperature, and average temperature. 
 * It also includes a method that accepts as an argument a temperature
 * and returns the number of days the temperatures was below that value. 
 */

using System;

namespace ArrayOfTemperaturesApp
{
    class ArrayOfTemperatures
    {
        private int[] temperature;

        public ArrayOfTemperatures()
        {
        }

        public ArrayOfTemperatures(int [ ] temp)
        {
            temperature = new int[temp.Length];
            temperature = temp;
        }

        public int[] Temperature
        {
            get
            {

                return temperature;
            }
            set
            {
                temperature = value;
            }
        }
        public double ReturnSum( )
        {
            int total = 0;
            foreach (int val in temperature)
                total += val;
            return total;
        }

        public double ReturnAverage()
        {
            return ReturnSum( ) / (double) temperature.Length;
        }

        public int ReturnSmallest()
        {
            int smallest = 999;
            foreach (int val in temperature)
                if (val < smallest)
                    smallest = val;
            return smallest;
        }

        public int ReturnLargest()
        {
            int largest = -999;
            foreach (int val in temperature)
                if (val > largest)
                    largest = val;
            return largest;
        }

        public double ReturnAverageExcludingSmallest()
        {
            return (ReturnSum() - ReturnSmallest()) / 
                ((double)(temperature.Length - 1));
        }

        public int ReturnDaysBelow(int temp)
        {
            int cnt = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                if (temperature[i] < temp)
                    cnt++;
            }
            return cnt;
        }

        public string DisplayTemperatureIn3ColTable()
        {
            string result ="Values in the Temperature Array\n";
            for(int i = 0; i < temperature.Length; i++)
            {
                if (i % 3 == 0)
                    result += "\n" + temperature[i] + "\t";
                else
                    result += temperature[i] + "\t";
               
            }
            return result;
        }


        public override string ToString()
        {
            return DisplayTemperatureIn3ColTable() +
                
                "\nTemperatures ranged from " + ReturnSmallest() + " to " + ReturnLargest();

        }
    }
}
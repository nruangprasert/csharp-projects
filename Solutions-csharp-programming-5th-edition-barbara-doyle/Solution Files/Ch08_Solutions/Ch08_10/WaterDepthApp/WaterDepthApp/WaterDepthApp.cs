using System;
using static System.Console;

namespace WaterDepthApp
{
    class WaterDepthApp
    {
        static void Main(string[] args)
        {
            double[,] waterDepth = new double[6, 5];
            string[] location = {"Surf City", "Solomons",  
                                 "Hilton Head", "Miami", "Savannah"};
            string[] recordingTime = {"0700 (7am)", "1200 (noon)", "1700 (5pm)", "2100 (9pm)" };

            InitializeArray(waterDepth);
            GetWaterDepths(waterDepth, location, recordingTime);
            FindAvgDepthByLocation(waterDepth);
            FindAvgDepthByTime(waterDepth);
            DisplayTable(waterDepth, location, recordingTime);
            ReadKey();
        }

        public static void InitializeArray(double[,] sales)
        {
            for (int row = 0; row < sales.GetLength(0); row++)
                for (int col = 0; col < sales.GetLength(1); col++)
                    sales[row, col] = 0;
        }

        public static void GetWaterDepths(double[,] waterDepth, string[] location, string[] recordingTime)
        {
            int locNum,
                recTime;
            string inputValue;
            bool moreData = true;
            while (moreData)
            {
                locNum = GetLocationNumber(location);
                recTime = GetRecTimeNum(recordingTime);
                waterDepth[locNum, recTime] = GetWaterDepths();  // Record last entered depth
                Write("\n\nIs there more depths to record? (y/n)");
                inputValue = ReadLine();
                switch (inputValue)
                {
                    case "n":
                    case "N":
                        moreData = false;
                        break;
                    default:
                        moreData = true;
                        break;
                }
            }
        }

        public static int GetLocationNumber(string[] location)
        {
            int locNum = -1;
            while (locNum > location.Length || locNum < 1)
            {
                Clear();
                WriteLine("   Water Depth \nRecording Application\n\n");
                for (int row = 0; row < location.Length; row++)
                {
                    WriteLine("{0}. {1}", row + 1, location[row]);
                }

                Write("\nDepths are for which location?  ");
                while (int.TryParse(ReadLine(), out locNum) == false)
                {
                    Write("Invalid data - input must be numeric: ");
                }
            }
            return locNum;
        }

        public static int GetRecTimeNum(string[] recordingTime)
        {
            int recTime = -1;
            while (recTime > recordingTime.Length || recTime < 1)
            {
                Clear();
                WriteLine("Recording Time\n\n");
                for (int i = 0; i < recordingTime.Length; i++)
                {
                    WriteLine("{0}. {1}", (i + 1), recordingTime[i]);
                }
                Write("\nDepth is for which time period?  ");
                while (int.TryParse(ReadLine(), out recTime) == false)
                {
                    Write("Invalid data - input must be numeric: ");
                }
            }
            return recTime;
        }

        public static double GetWaterDepths()
        {
            double depth;
            Write("\n\nWhat was the reported depth? ");
            while (double.TryParse(ReadLine(), out depth) == false)
            {
                Write("Invalid data - input must be numeric: ");
            }
            return depth;
        }

        public static void DisplayTable(double[,] waterDepth, string[] location, string[] recordingTime)
        {
            //Displays the headings
            Clear();
            WriteLine("\t\t\tWater Depths Summary\n\n");
            Write("{0, -20}", "Location Name");
            for (int i = 0; i < recordingTime.Length; i++)
            {
                Write("  {0, -10}", recordingTime[i]);
            }
            WriteLine("{0, 8}", "Average");

            //Displays the locations - starting at index 1 because
            //row indexed by 0 holds the average for each time period
            for (int row = 1; row < waterDepth.GetLength(0); row++)
            {
                Write("{0, -18}", location[row - 1]);
                for (int col = 1; col < waterDepth.GetLength(1); col++)
                {
                    Write("{0,12:N2}", waterDepth[row, col]);
                }
                WriteLine("{0,10:N2}", waterDepth[row, 0]);  // Writes the average of the location
            }

            WriteLine();

            // Displays the last row - which holds the average of the time periods
            Write("{0, -18}", "Average");
            for (int i = 1; i < recordingTime.Length + 1; i++)      // Write the average by time
            {
                Write("{0,12:N2}", waterDepth[0, i]);
            }
            WriteLine();
        }

        public static void FindAvgDepthByLocation(double[,] waterDepth)
        {
            int cntOfActualData = 0;
            double total = 0;
            for (int row = 1; row < waterDepth.GetLength(0); row++)
            {
                for (int col = 1; col < waterDepth.GetLength(1); col++)
                {
                    if (waterDepth[row, col] > 0)
                    {
                        total += waterDepth[row, col];
                        cntOfActualData++;
                    }
                }
                if (cntOfActualData != 0)
                {
                    waterDepth[row, 0] = total / cntOfActualData;    // Store average in column zero
                    total = 0;
                    cntOfActualData = 0;
                }
                else
                    waterDepth[row, 0] = 0;
            }
        }

        public static void FindAvgDepthByTime(double[,] waterDepth)
        {
            int cntOfActualData = 0;
            double total = 0;
            for (int col = 1; col < waterDepth.GetLength(1); col++)
            {
                for (int row = 1; row < waterDepth.GetLength(0); row++)
                {
                    if (waterDepth[row, col] > 0)
                    {
                        total += waterDepth[row, col];
                        cntOfActualData++;
                    }
                }
                if (cntOfActualData != 0)
                {
                    waterDepth[0, col] = total / cntOfActualData;    // Store average in row zero
                    total = 0;
                    cntOfActualData = 0;
                }
                else
                    waterDepth[0, col] = 0;
            }
        }
    }
}

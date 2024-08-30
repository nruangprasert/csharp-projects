/* ExerciseApp.cs
 * This application displays statistics for 
 * two types of exercise classes for six days over four 
 * time periods. Total revenue is displayed by day and time.
 */
using System;
using static System.Console;

namespace ExerciseApp
{
    class ExerciseApp
    {
        static void Main(string[] args)
        {
            int[ , , ] attendees = 
                new int[2, 7, 5] 
                        { { { 12, 10, 17, 22, 0 },
                            { 11, 13, 17, 22, 0 },
                            { 12, 10, 22, 22, 0 },
                            { 9, 14, 17, 22, 0 },
                            { 12, 10, 21, 12, 0 },
                            { 12, 10, 5, 10, 0 } ,
                            { 0, 0, 0, 0, 0 } },
                          { { 7, 11, 15, 8, 0 },
                            { 9, 9, 9, 9, 0 },
                            { 3, 12, 13, 7, 0 },
                            { 2, 9, 9, 10, 0 },
                            { 8, 4, 9, 4, 0 },
                            { 4, 5, 9, 3, 0 } ,
                            { 0, 0, 0, 0, 0 } } };
            double [ , ] dailyRevenue = new double [6, 2];
            double[ , ] timePeriodRevenue = new double[4, 2];
            double[] rateTable = new double[2] { 4, 5 };

            ComputeDayTotals(attendees, dailyRevenue, rateTable);
            ComputeActivityTimeTotals(attendees, timePeriodRevenue, rateTable);
            DisplayTable(attendees, dailyRevenue, rateTable);
            ReadKey();
        }

        public static void ComputeDayTotals(int[, ,] attendees,  double [ , ] dailyRevenue,  double[] rateTable)
        {
            for (int p = 0; p < attendees.GetLength(0); p++)
            {
                for (int r = 0; r < attendees.GetLength(1) - 1; r++)
                {
                    for (int c = 0; c < attendees.GetLength(2) - 1; c++)
                    {
                        attendees[p, r, ((attendees.GetLength(2)) - 1)] += attendees[p, r, c];
                    }
                    dailyRevenue[r, p] = rateTable[p] * attendees[p, r, ((attendees.GetLength(2)) - 1)];
                }
            }
        }

        public static void ComputeActivityTimeTotals(int[, ,] attendees, double[,] timePeriodRevenue, double[] rateTable)
        {
            for (int p = 0; p < attendees.GetLength(0); p++)
            {
                for (int c = 0; c < attendees.GetLength(2) - 1; c++)
                {
                    for (int r = 0; r < attendees.GetLength(1) - 1; r++)
                    {
                        attendees[p, (attendees.GetLength(1) - 1), c] += attendees[p, r, c];
                    }
                    timePeriodRevenue[c, p] = rateTable[p] * attendees[p, (attendees.GetLength(1) - 1), c];
                }
            }
        }


        public static void DisplayTable(int[, ,] attendees, double [ , ] dailyRevenue, double [ ] rateTable)
        {
            int r, p, c;

            string[ ] typeOfExercise = new string[ ] { "Zumba", "Spinning" };
            string[ , ] exerciseTimes = new string[,] {{ "1:00", "3:00", "5:00", "7:00" },
                                               { "2:00", "4:00", "6:00", "8:00" }};

            WriteLine("\t\t\tTappan Gym Weekly Report\n");

            // Display headings for each exercise groups
            for (p = 0; p < attendees.GetLength(0); p++)
            {
                WriteLine("{0, 30} Attendees", typeOfExercise[p]);
                Write("{0,6}", "");
                for (int i = 0; i < exerciseTimes.GetLength(1); i++)
                    Write("{0,10}", exerciseTimes[p, i]);
                Write("{0, 10}{1, 14}", "Total", "Revenue");
                WriteLine();

            // Display table with totals and revenue
                for (r = 0; r < (attendees.GetLength(1) -1); r++)
                {
                    Write("{0,6}", "");
                    for (c = 0; c < attendees.GetLength(2); c++)
                        Write("{0, 10}", attendees[p, r, c]);
                    Write("{0, 14:F2}", dailyRevenue[r, p]);
                    WriteLine();
                }

            // Display time totals
                Write("{0,6}", "Totals");
                for (c = 0; c < attendees.GetLength(2)-1; c++)
                {
                    Write("{0, 10}", attendees[p, 6, c]);
                }
         
           // Display final totals
                for (int i = 0; i < attendees.GetLength(2)-1; i++)
                {
                    attendees[p, 6, 4] += attendees[p, 6, i];
                }
                Write("{0, 10}", attendees[p, 6, 4]);
  

            // Display final revenue
                Write("{0, 14:C}", (attendees[p, 6, 4] * rateTable[p]));

                WriteLine();
                WriteLine();
                WriteLine();
            } // end of outermost for
        }
    }
}

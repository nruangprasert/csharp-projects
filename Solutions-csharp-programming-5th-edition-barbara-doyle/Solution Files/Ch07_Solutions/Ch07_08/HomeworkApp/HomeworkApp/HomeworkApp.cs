/* HomeworkApp.cs
 * This application allows the user to input
 * any number of homework scores ranging
 * in value from 0 through 10.  The highest and 
 * lowest scores are discarded and an average 
 * calculated using the remaining scores.
 * The results are displayed.
 */
using System;
using System.Console;

namespace HomeworkApp
{
    class HomeworkApp
    {
        static void Main(string[] args)
        {
            int[] numsInput = new int[100];
            int[] homeWorkScores;
            double average;
            int numOfScores;

            DisplayInformationAboutApp();
            numOfScores = PromptForNums(numsInput);
            homeWorkScores = StoreDataInFixedSizedArray(numsInput, numOfScores);
            Array.Sort(homeWorkScores);
            average = CalculateAverage(homeWorkScores);
            DisplayResults(homeWorkScores, average);
            ReadKey();
        }

        public static void DisplayInformationAboutApp()
        {
            WriteLine("\t\t******************" +
                "\n***You will be prompted to enter homework scores.                ***" +
                "\n***Valid values are 0 through 10.                               ***" +
                "\n***The highest and lowest scores will be discarded.              ***" +
                "\n***Average is calculated (and displayed) using remaining values. ***" +
                "\n********************************************************************");
            WriteLine("\n");
        }

        public static int PromptForNums(int[] numsInput)
        {
            string input;
            int numInput;
            bool valueInRange = true;
            int cnt = 0;
            Write("Please enter homework score [0 to 10] (-99 to exit): ");

            input = ReadLine();

            while (input != "-99")
            {
                while (int.TryParse(input, out numInput) == false)
                {
                    Write("\tInvalid data - re-enter homework score: ");
                    input = ReadLine();
                }
                valueInRange = CheckValueRange(numInput);
                if (valueInRange)
                {
                    numsInput[cnt] = numInput;
                    cnt++;
                }
                else
                {
                    WriteLine("\nThe integer entered, {0}, is not " +
                        "between 0 and 10.\n", numInput);
                }
                
                Write("Please enter homework score [0 to 10] (-99 to exit): ");
                input = ReadLine();
            }
            return cnt;
        }

        public static int[ ] StoreDataInFixedSizedArray(int[] numsInput, int numberOfScores)
        {
            int[] homeWorkScores = new int[numberOfScores];

            for (int i = 0; i < numberOfScores; i++)
            {
                homeWorkScores[i] = numsInput[i];
            }
            return homeWorkScores;
        }

        public static bool CheckValueRange(int inValue)
        {
            bool inRange;
            if (inValue > -1)
                if (inValue < 11)
                    inRange = true;
                else
                    inRange = false;
            else
                inRange = false;
            return inRange;

        }

        public static double CalculateAverage(int[] homeWorkScores)
        {
            int total = 0;
            double average; 
            if (homeWorkScores.Length > 2)  // In order to exclude largest and smallest
            {
                for (int i = 1; i < homeWorkScores.Length - 1; i++)
                {
                    total += homeWorkScores[i];
                }
                average = (double) total / (homeWorkScores.Length - 2);
            }
            else
                average = 0;  
            return average;
        }

        public static int DetermineLargestScore(int [ ] homeWorkScores)
        {
            int largestScore;
            if (homeWorkScores.Length > 0)
                largestScore = homeWorkScores[homeWorkScores.Length - 1];
            else
                largestScore = 0;
            return largestScore;
        }

        public static int DetermineSmallestScore(int[] homeWorkScores)
        {
            int smallestScore;
            if (homeWorkScores.Length > 0)
                smallestScore = homeWorkScores[0];
            else
                smallestScore = 0;
            return smallestScore;
        }

        public static void DisplayResults(int[] nums, double average)
        {
            Clear();
            WriteLine("\tHomework App");
            WriteLine("Highest Score:\t{0}", DetermineLargestScore(nums));
            WriteLine("Lowest Score:\t{0}", DetermineSmallestScore(nums));
            WriteLine("\nAverage Score (excluding lowest & highest scores): " + average.ToString("F1"));
        }

    }
}

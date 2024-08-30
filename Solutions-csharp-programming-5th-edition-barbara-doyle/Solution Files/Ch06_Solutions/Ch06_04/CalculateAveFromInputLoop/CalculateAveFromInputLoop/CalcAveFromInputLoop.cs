/* CalcAveFromInputLoop.cs
 * This program prompts for input
 * of scores 0 - 100, calculates the 
 * average, assigns a letter grade
 * based on the average. Display the
 * results.
 */

using System;
using static System.Console;

namespace CalcAveFromInputLoop
{
    class CalcAveFromInputLoop
    {
        static void Main( )
        {
            bool enterMoreScores = true;
            int totalScoresPerStudent,
                countOfScoresEntered;
            double average;
            char grade;

            DisplayInstructions();
            do
            {
                totalScoresPerStudent = 0;
                countOfScoresEntered = PromptForAllScoresForOneStudent(ref totalScoresPerStudent);
                average = CalculateAverage(countOfScoresEntered, totalScoresPerStudent);
                grade = GetGrade(average);
                DisplayResults(countOfScoresEntered, average, grade);
                enterMoreScores = GetInput();
            } while (enterMoreScores);

            ReadKey();
        }

        static void DisplayInstructions()
        {
            WriteLine(" *********************************************************************" +
                "\n ***   You will be prompted to input scores ranging from 0 to 100. ***" +
                "\n ***   The scores entered will be averaged and a letter grade      ***" +
                "\n ***   assigned. The results will then be displayed. You may enter ***" +
                "\n ***   as many sets of scores as you would like.                   ***" +
                "\n ***                                                               ***" +
                "\n ***         Enter a negative value to stop entering scores.       ***" +
                "\n *********************************************************************" +
                "\n\n\n\tPress any key when you are ready to begin...");
            ReadKey();
            Clear();
        }

        static bool GetInput()
        {
            char input;
            bool enterMoreData;
            Write("\n\nWould you like to enter another set of scores? " +
                "\nPlease enter 'Y' for YES or any other letter for NO... ");
            if (char.TryParse(ReadLine(), out input) == false) // In case they enter more than one character
                input = 'n';
 
            switch (input)
            {
                case 'y':
                case 'Y': enterMoreData = true;
                    Clear();
                    break;
                default: enterMoreData = false;
                    break;
            }

            return enterMoreData;
        }

        static int PromptForAllScoresForOneStudent(ref int totalScores)
        {
            int numberOfScores = 0,
                score;

            score = ReturnValidScore();
            while (score > -1 )
            {
                totalScores += score;
                numberOfScores += 1;
                score = ReturnValidScore();
            }
            return numberOfScores;

        }

        static int ReturnValidScore()
        {
            string input;
            int score;

            Write("\nPlease enter a score 0 - 100 ." +
                   "\nEnter a number LESS than 0 to STOP entering scores: ");
            input = ReadLine();
            while (int.TryParse(input, out score) == false || score > 100)
            {
                WriteLine("Invalid data entered - please re-enter the score: ");
				Write("Score must be numeric (0 - 100): ");

				input = ReadLine();
            }
            return score;
        }

        static double CalculateAverage(int numberOfScores, int totalScores)
        {
            double average;
            if (numberOfScores > 0)
                average = (double)totalScores / numberOfScores;
            else
                average = 0;

            return average;

        }

        static char GetGrade(double average)
        {
            char letterGrade;
            if (average > 89.49)
            {
                letterGrade = 'A';
            }
            else
                if (average > 79.49)
                {
                    letterGrade = 'B';
                }
                else
                    if (average > 69.49)
                    {
                        letterGrade = 'C';
                    }
                    else
                        if (average > 59.49)
                        {
                            letterGrade = 'D';
                        }
                        else
                        {
                            letterGrade = 'F';
                        }

            return letterGrade;
        }

        static void DisplayResults(int numberOfScores, double average, char letterGrade)
        {
            Clear();
            if (numberOfScores != 0)
            {
                WriteLine("\n********************************************");
                WriteLine("\tGrade App");
                WriteLine("Number of scores entered: {0}", numberOfScores);
                WriteLine("Average: {0:f2}", average);
                WriteLine("Grade: {0}", letterGrade);
                WriteLine("********************************************");
            }
            else
            {
                Clear();
                WriteLine("No scores were entered");
            }
        }
    }
}

/* GradePointAverageApp.cs
 * This application calculates a student’s GPA on a 4.0 scale. 
 * The user inputs any number of courses and associated grades. 
 * The number of hours earned and the GPA are displayed.
 */

using System;
using static System.Console;

namespace GradePointAverageApp
{
    class GradePointAverageApp
    {
        static void Main(string[] args)
        {
            bool enterMoreCourses = true;
            int totalQualityPoints = 0,
                hoursCredit,
                qualityPoints,
                totalHours = 0;
            char gradeEarned;
            double gpa;

            DisplayInstructions();
            do
            {
                gradeEarned = PromptForGrade();
                hoursCredit = PromptForNumberOfHoursForCourse( );

                qualityPoints = ComputeQualityPointsForCourse(gradeEarned, hoursCredit);
                totalQualityPoints += qualityPoints;
                totalHours += hoursCredit;
                enterMoreCourses = AskForMoreData();
            } while (enterMoreCourses);
            gpa = ComputeGPA(totalHours, totalQualityPoints);
            DisplayResults(totalHours, gpa);
            ReadKey();
        }

        static void DisplayInstructions()
        {
            WriteLine(" *********************************************************************" +
                "\n ***   You will be prompted to input number of hours                      ***" +
                "\n ***   and the letter grade earned for the course.                        ***" +
                "\n ***   GPA is calculated and displayed.                                   ***" + 
                "\n ***   Enter as many grade/hour combination as needed.                    ***" +
                "\n *********************************************************************" +
                "\n\n\n\tPress any key when you are ready to begin...");
            ReadKey();
            Clear();
        }

        static bool AskForMoreData()
        {
            char input;
            bool enterMoreData;
            Write("\n\nWould you like to enter another course? " +
                        "\nPlease enter 'Y' for YES or any other letter for NO... ");
            if (char.TryParse(ReadLine(), out input) == false) // In case they enter more than one character
            {
                WriteLine("Invalid data entered - N recorded as response");
                input = 'n';
            }
            switch (input)
            {
                case 'y':
                case 'Y': enterMoreData = true;
                    break;
                default: enterMoreData = false;
                    break;
            }

            return enterMoreData;
        }

        static char PromptForGrade( )
        {
            char grade;

            Clear();
            Write("Please enter course grade (A,B,C,D, or F): ");
            if (char.TryParse(ReadLine(), out grade) == false) // In case they enter more than one character
            {                               
                WriteLine("Invalid data entered - ? recorded as response");
                grade = '?';
            }
            return grade;
        }

        static int PromptForNumberOfHoursForCourse( )
        {
            string input;
            int hours;

            Write("Please enter the number of hours earned for the course: ");
            input = ReadLine();
            while (int.TryParse(input, out hours) == false)
            {
                Write("Invalid data entered - please re-enter the score: ");
                input = ReadLine();
            }
            return hours;
        }

        static int ComputeQualityPointsForCourse(char gradeEarned, int hoursCredit)
        {
            int qualityPoints,
                qualityPtMultiplier;

            switch( gradeEarned)
            {
                case 'A' :
                case 'a' : qualityPtMultiplier = 4;
                    break;
                case 'B':
                case 'b': qualityPtMultiplier = 3;
                    break;
                case 'C':
                case 'c': qualityPtMultiplier = 2;
                    break;
                case 'D':
                case 'd': qualityPtMultiplier = 1;
                    break;
                default:  qualityPtMultiplier = 0;
                    break;
            }
            qualityPoints = qualityPtMultiplier * hoursCredit;
            return qualityPoints;
        }

        static double ComputeGPA(int totalHours, int totalQualityPoints)
        {
            return (double)totalQualityPoints / totalHours;
        }

        static void DisplayResults(int numberOfHoursEarned, double gpa)
        {
            Clear();
            if (numberOfHoursEarned != 0)
            {
                WriteLine("\n********************************************");
                WriteLine("\tGrade Point Average App");
                WriteLine("Number of Hours Earned: {0}", numberOfHoursEarned);
                WriteLine("GPA: {0:f2}", gpa);
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


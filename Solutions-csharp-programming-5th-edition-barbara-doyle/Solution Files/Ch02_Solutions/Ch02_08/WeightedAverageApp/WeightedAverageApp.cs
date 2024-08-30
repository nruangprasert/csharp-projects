/* WeightedAverageApp.cs
 * This application computes a weighted average giving the following weights. 
    Homework: 10%
    Projects: 35%
    Quizzes: 10%
    Exams: 30%
    Final Exam: 15%
 */

using System;
using static System.Console;

namespace WeightedAverageApp
{
    class WeightedAverageApp
    {
        static void Main( )
        {
            const double HOMEWORK = 0.10;
            const double PROJECTS = 0.35;
            const double QUIZZES = 0.10;
            const double EXAMS = 0.30;
            const double FINAL = 0.15;

            int homeworkAverage = 97;
            int projectAverage = 82;
            int quizAverage = 60;
            int examAverage = 75;
            int final = 80;

            double overallAverage;

            overallAverage = homeworkAverage * HOMEWORK + projectAverage * PROJECTS + quizAverage * QUIZZES +
                                examAverage * EXAMS + final * FINAL;

            WriteLine("\tGrading App\n");
            WriteLine("{0,-11}({1:P0}):{2,5}", "Homework", HOMEWORK, homeworkAverage);
            WriteLine("{0,-11}({1:P0}):{2,5}", "Projects", PROJECTS, projectAverage);
            WriteLine("{0,-11}({1:P0}):{2,5}", "Quizzes", QUIZZES, quizAverage);
            WriteLine("{0,-11}({1:P0}):{2,5}", "Exams", EXAMS, examAverage);
            WriteLine("{0,-11}({1:P0}):{2,5}", "Final Exam", FINAL, final);
            WriteLine("Wighted Average: {0,9:F2}", overallAverage);

            ReadKey();
        }
    }
}

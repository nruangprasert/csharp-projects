/* ProfessorRatingApp.cs
 * This class instantiates objects of the
 * ProfessorRating class. It tests the different
 * constructors, properties and methods of that class.
 */

using System;
using static System.Console;

namespace ProfessorRatingApp
{
    class ProfessorRatingApp
    {
        static void Main(string[] args)
        {
            int score1,
                score2,
                score3;
            string  professorID,
                    firstName,
                    lastName;

            DisplayInstructions();

            professorID = GetInfo("Professor Number");
            firstName = GetInfo("Professor\'s First Name");
            lastName = GetInfo("Professor\'s Last Name");
            WriteLine();
            score1 = int.Parse(GetInfo("Easiness Rating"));
            score2 = int.Parse(GetInfo("Helpfulness Rating"));
            score3 = int.Parse(GetInfo("Clarity Rating"));
            ProfessorRating firstStudent = new ProfessorRating(professorID, 
                        firstName, lastName, score1, score2, score3);
            DisplayResults(firstStudent);

            WriteLine("\nPress any key to see the next test...");
            ReadKey();
            Clear();
            
            ProfessorRating secondProf = new ProfessorRating("JU-1231");
            secondProf.ProfessorFirstName = "Natalia";
            secondProf.ProfessorLastName = "Gonzalas";
            secondProf.FirstScore = int.Parse(GetInfo("Easiness Rating (1-5)"));
            secondProf.SecondScore = int.Parse(GetInfo("Helpfulness Rating (1-5)"));
            secondProf.ThirdScore = int.Parse(GetInfo("Clarity Rating (1-5)"));
            Clear();
            WriteLine(secondProf);

            WriteLine("\nPress any key to see the next test...");
            ReadKey();
            Clear();

            ProfessorRating anotherProf = new ProfessorRating("UC-1143", "Morris", "Dennis", 3, 5, 4);
            WriteLine(anotherProf);
            ReadKey();
        }

        static void DisplayInstructions()
        {
            WriteLine("You will be asked to enter a profesor ID number and three ratings." +
                    "\nThe ratings relates to easiness, helpfulness, and clarity - in that order." +
                    "\nThe information, including average rating will be displayed.\n\n" +
                    "Ratings are based on a 1 - 5 scale with 1 being the lowest and 5 the highest");
            WriteLine("\n\nPress any key when you are ready to begin...");

            ReadKey();
            Clear();
        }

        static string GetInfo(string info)
        {
            string inputValue;

            Write("Please enter the {0}: ", info);
            inputValue = ReadLine();
            return inputValue;
        }

        static void DisplayResults(ProfessorRating person)
        {
            Clear();
            WriteLine("\nProfessor Number: {0} ", person.ProfessorNumber);
            WriteLine("Professor Name: {0} {1}", person.ProfessorFirstName, person.ProfessorLastName); 
            WriteLine("\nEasiness: {0}", person.FirstScore);
            WriteLine("Helpfulness: {0}", person.SecondScore);
            WriteLine("Clarity: {0}", person.ThirdScore);
            WriteLine("\nAverage Rating: {0}\n\n",
                       person.CalculateAverageRating().ToString("F2"));
        }
    }
}

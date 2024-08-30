﻿/* ProfessorRating.cs
 * This class provides the
 * structure for each Professor Rating object.
 * It includes private data members
 * for professor number and three ratings.
 * It includes a method to
 * calculate the average rating.
*/
using System;

namespace ProfessorRatingApp
{
    class ProfessorRating
    {
        private string professorNumber;
        private string professorLastName;
        private string professorFirstName;
        private int firstScore;
        private int secondScore;
        private int thirdScore;

        public ProfessorRating(string ID, string first, string last, int score1, int score2, 
			                   int score3)
        {
            professorNumber = ID;
            professorFirstName = first;
            professorLastName = last;
            firstScore = score1;
            secondScore = score2;
            thirdScore = score3;
        }

        public ProfessorRating(string ID, int score1, int score2,
							   int score3)
        {
            professorNumber = ID;
			firstScore = score1;
			secondScore = score2;
			thirdScore = score3;
		}

		public ProfessorRating()
        {
        }

		public ProfessorRating(string ID)
		{
			professorNumber = ID;
		}



		public string ProfessorNumber
        {
            get
            {
                return professorNumber;
            }
        }

        public string ProfessorFirstName
        {
            get
            {
                return professorFirstName;
            }
            set
            {
                professorFirstName = value;
            }
        }
        public string ProfessorLastName
        {
            get
            {
                return professorLastName;
            }
            set
            {
                professorLastName = value;
            }
        }
        public int FirstScore
        {
            get
            {
                return firstScore;
            }
            set
            {
                firstScore = value;
            }
        }

        public int SecondScore
        {
            get
            {
                return secondScore;
            }
            set
            {
                secondScore = value;
            }
        }

        public int ThirdScore
        {
            get
            {
                return thirdScore;
            }
            set
            {
                thirdScore = value;
            }
        }

        public double CalculateAverageRating()
        {
            return (firstScore + secondScore + thirdScore) / 3.0;
        }

        public override string ToString()
        {
            return "Professor Number: " + professorNumber +
                "\nProfessor Name: " + professorFirstName + " " + professorLastName +
                "\nEasiness: " + firstScore +
                "\nHelpfulness: " + secondScore +
                "\nClarity: " + thirdScore +
                "\nAverage Rating: " + CalculateAverageRating().ToString("F2");
        }
    }
}

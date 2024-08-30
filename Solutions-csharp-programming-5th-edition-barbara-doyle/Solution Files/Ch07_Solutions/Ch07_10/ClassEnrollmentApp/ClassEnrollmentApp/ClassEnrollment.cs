/* ClassEnrollment.cs
 * This class has three data members, course name, 
 * and current and max enrollments for the 
 * corresponding courses. An instance method returns
 * the number of spots open for the course.
 */
using System;

namespace ClassEnrollmentApp
{
    class ClassEnrollment
    {
        private string courseName;
        private int maxEnrollment;
        private int currentEnrollment;

        public ClassEnrollment()
        {
        }

        public ClassEnrollment(string course, int max, int current)
        {
            courseName = course;
            maxEnrollment = max;
            currentEnrollment = current;
        }

        public ClassEnrollment(string course)
        {
            courseName = course;
        }

        public ClassEnrollment(int max, int current)
        {
            maxEnrollment = max;
            currentEnrollment = current;
        }

        public ClassEnrollment(string course, int max )
        {
            courseName = course;
            maxEnrollment = max;
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }

        public int CurrentEnrollment
        {
            get
            {
                return currentEnrollment;
            }
            set
            {
                currentEnrollment = value;
            }
        }

        public int MaxEnrollment
        {
            get
            {
                return maxEnrollment;
            }
            set
            {
                maxEnrollment = value;
            }
        }

        public int DetermineNumberOfOpenSlots()
        {
            return maxEnrollment - currentEnrollment;
        }

        public override string ToString()
        {
            return courseName + "\t\t" + currentEnrollment + 
                   "\t\t" + DetermineNumberOfOpenSlots();
        }
     }

}

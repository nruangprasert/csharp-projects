/* ClassEnrollmentApp.cs
 * This classes tests the class ClassEnrollments.
 * It declares an array of objects, allows the 
 * user to input the data and tests the instance
 * methods of theClassEnrollment class.
 */
using System;
using System.Windows.Forms;

namespace ClassEnrollmentApp
{
    class ClassEnrollmentApp
    {
        static void Main(string[] args)
        {
            string [] className = new string[] 
						{"CS150", "CS250", "CS270", "CS300", "CS350"};
			int [] currentEnrollment = new int[] {180, 21, 09, 04, 20};
			int [] maxEnrollment = new int[] {200, 30, 20, 20, 20};
            ClassEnrollment [ ] currentClasses = new ClassEnrollment[5];

            currentClasses =  InstantiateClass(className, maxEnrollment, currentEnrollment);
            DisplayResults(currentClasses);
		}

        public static string ProduceHeading( )
        {
            string heading = "Class\t\tCurrent\t\tSeats\n" +
                             "Name\t\tEnrollment\tAvailable\n";
            return heading;
        }

        public static ClassEnrollment[] InstantiateClass(string [ ] className, int[ ] maxEnrollment, int[ ] currentEnrollment)
        {
            ClassEnrollment [ ] temp = new ClassEnrollment[className.Length];
            for (int i = 0; i < className.Length; i++)
            {
                temp[i] = new ClassEnrollment(className[i], maxEnrollment[i], currentEnrollment[i]);
                temp[i].CurrentEnrollment = currentEnrollment[i];
                temp[i].MaxEnrollment =  maxEnrollment[i];
            }
            return temp;
         }

        public static void DisplayResults(ClassEnrollment[] courseData)
        {
            string output = ProduceHeading();

            for (int x = 0; x < courseData.Length; x++)
            {
                output += courseData[x] + "\n";
            }
            MessageBox.Show(output, "Course Enrollment App");
        }


    }
}
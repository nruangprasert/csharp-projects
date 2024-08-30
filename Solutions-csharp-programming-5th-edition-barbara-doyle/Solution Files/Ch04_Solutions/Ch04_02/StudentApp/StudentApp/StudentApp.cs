/*StudentApp.cs  
 * This program includes two classes. 
 * This class tests the Student class by 
 * instantiating objects of the class and 
 * testing its properties and mehtods.
 */
using System;
using static System.Console;

namespace StudentApp
{
    class StudentApp
    {
        static void Main(string[] args)
        {
            
            Student oneStudent = new Student("0001234567", "Joan", "Logan",
                                             "Senior", "English");
            WriteLine("\tFirst Test");
            DisplayInfo(oneStudent);

            Student anotherStudent = new Student("Chin", "Chang");
            anotherStudent.StudentNum = "0001222876";
            anotherStudent.Classification = "Junior";
            anotherStudent.Major = "CS";

            WriteLine("\n\n\tAnother Test");
            WriteLine(anotherStudent);

            ReadKey();
        }

        static void DisplayInfo(Student aStudent)
        {
            WriteLine("Name: {0}", aStudent.ReturnFullName());
            WriteLine("Major: {0}", aStudent.Major);
        }
    }
}

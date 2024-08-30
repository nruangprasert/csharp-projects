using System;
using System.ComponentModel;

namespace Chapter04Question02
{
    internal class StudentApp
    {
        static void Main(string[] args)
        {
            int studentCount = 2;

            for (int i = 1; i <= studentCount; i++)
            {
                int studentNumber = ReceiveInt("student number");
                string firstName = ReceiveStr("first name");
                string lastName = ReceiveStr("last name");
                string classification = ReceiveStr("classification");
                string major = ReceiveStr("major");

                Student student = new Student(studentNumber, firstName, lastName, classification, major);
                Console.WriteLine(student);

                Display(firstName, lastName, major);

                Console.ReadKey();

            }
        }
        static int ReceiveInt(string value)
        {
            Console.Write($"Enter {value} : ");
            return int.Parse(Console.ReadLine());
        }
        static string ReceiveStr(string value)
        {
            Console.Write($"Enter {value} : ");
            return Console.ReadLine();
        }
        static void Display(string firstName, string lastname, string major)
        {
            Console.WriteLine($"Fullname = {firstName} {lastname} and Major = {major}");
        }
    }
}

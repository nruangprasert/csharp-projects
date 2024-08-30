using System;
using static System.Console;

namespace VanTien_7_8
{
    class Student
    {
        int id;
        string name;
        double[] CGPA;

        public Student(int id, string name, double[] cGPA)
        {
            this.id = id;
            this.name = name;
            this.CGPA = cGPA;
        }

        public override string ToString()
        {
            string cgpaStr = "";
            for (int i = 0; i < CGPA.Length; i++)
            {
                if (i > 0)
                {
                    cgpaStr += ", ";
                }

                cgpaStr += CGPA[i];
            }
            return "\n----------------------------\n"
                + $"Student ID: {id}\n"
                + $"Student name: {name}\n"
                + $"Student CGPA: {cgpaStr}\n"
                ;
        }
    }
    internal class Program
    {
                
        static void Main()
        {
            Write("Please input student information ");
           
            Student[] students = new Student[3];

            for (int i = 0; i < 3; i++)
            {
                WriteLine($"Please input student {i + 1}: ");
                Write("Student Id: ");
                int id;
                while (!int.TryParse(ReadLine(), out id)) Write("Invalid. Again: ");
                Write("Student Name: ");
                string name = ReadLine();

                double[] cgpa = new double[3];
                for (int j = 0; j < cgpa.Length; j++)
                {
                    Write($"GPA for {j + 1} course: ");
                    while (!double.TryParse(ReadLine(), out cgpa[j])) Write("Invalid. Again: ");
                }

                students[i] = new Student(id, name, cgpa);
            }

            Write("Student information:\n");
            for (int i = 0; i < 3; i++)
            {
                Write($"Student number {i + 1}");
                WriteLine(students[i]);
            }
            ReadKey();
        }
    }
}
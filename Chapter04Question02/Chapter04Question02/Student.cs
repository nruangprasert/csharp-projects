using System;

namespace Chapter04Question02
{
    internal class Student
    {
        private int studentNumber;
        private string firstName;
        private string lastName;
        private string classification;
        private string major;

        public Student()
        {

        }
        public Student(int studentNumber, string firstName, string lastName, string classification, string major)
        {
            this.studentNumber = studentNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.classification = classification;
            this.major = major;
        }

        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Classification { get; set; }
        public string Major { get; set; }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }


    }
}

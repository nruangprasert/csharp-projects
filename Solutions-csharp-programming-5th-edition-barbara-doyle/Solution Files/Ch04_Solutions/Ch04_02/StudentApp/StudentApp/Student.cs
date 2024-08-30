using System;

namespace StudentApp
{
    class Student
    {
        private string studentNum;
        private string firstName;
        private string lastName;
        private string classification;
        private string major;

        // Default constructor
        public Student()
        {
        }

        // Constructor used to create Student object
        public Student(string num, string first, string last, 
                       string year, string focus)
        {
            studentNum = num; 
            firstName = first;
            lastName = last;
            classification = year;
            major = focus;
        }

        public Student(string first, string last)
        {
            firstName = first;
            lastName = last;
        }

        public Student(string first, string last, string focus)
        {
            firstName = first;
            lastName = last;
            major = focus;
        }

        public string StudentNum
        {
            get
            {
                return studentNum;
            }
            set
            {
                studentNum = value;
            }
        }

        // First Name Property
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        // Last Name Property
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        // Classification Property
        public string Classification
        {
            get
            {
                return classification;
            }
            set
            {
                classification = value;
            }
        }

        // Major Property
        public string Major
        {
            get
            {
                return major;
            }
            set
            {
                major = value;
            }
        }

        public string ReturnFullName()
        {
            return firstName + " " + lastName;
        }

        public override string ToString()
        {
            return "Student Number: " + studentNum +
                "\nName: " + ReturnFullName() +
                "\nClassification: " + classification +
                "\nMajor: " + major;
        }
    }
}

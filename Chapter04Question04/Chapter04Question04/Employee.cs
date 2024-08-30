using System;
using System.Collections.Generic;

namespace Chapter04Question04
{
    internal class Employee
    {
        private int employeeNumber;
        private string firstName;
        private string lastName;
        private string dateOfHire;
        private string jobDescription;
        private string department;
        private double monthlySalary;
        public Employee()
        {

        }
        public Employee(int employeeNumber, string firstName, string lastName, string dateOfHire, string jobDescription, string department, double monthlySalary)
        {
            this.employeeNumber = employeeNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfHire = dateOfHire;
            this.jobDescription = jobDescription;
            this.department = department;
            this.monthlySalary = monthlySalary;
        }
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string DateOfHire { get; set; }
        public string JobDescription { get; set; } 
        public string Department { get; set; } 
        public double MonthlySalary { get; set; }

        public string FullName()
        {
            return firstName + " " + lastName;
        }

        public string FormattedName()
        {
            return lastName + ", " + firstName;
        }

        public override string ToString()
        {
            return "\nEmployee Number : " + employeeNumber +
                    "\nFirst Name : " + firstName +
                    "\nLast Name : " + lastName +
                    "\nDate of Hire : " + dateOfHire +
                    "\nJob Description : " + jobDescription +
                    "\nDepartment : " + department +
                    "\nMonthly Salary : " + monthlySalary.ToString("c2");
        }
    }
}

using System;

namespace NattA1_1175_002
{
    internal class Employee
    {
        //Instance variables
        private string employeeName;
        private int employeeNumber;
        private string department;
        private double hourlyPayRate;
        private double hoursWorked;

        //Default constructor
        public Employee()
        {
        }

        //Parameterized constructor
        public Employee(string employeeName, int employeeNumber, string department, double hourlyPayRate, double hoursWorked)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.hourlyPayRate = hourlyPayRate;
            this.hoursWorked = hoursWorked;
        }

        //Properties
        public string EmployeeName
        {
            get; set;
        }
        public int EmployeeNumber
        {
            get; set;
        }
        public string Department
        {
            get; set;
        }
        public double HourlyPayRate
        {
            get; set;
        }
        public double HoursWorked
        {
            get; set;
        }

        //Method CalculateGrossPay
        public double CalculateGrossPay()
        {
            return hoursWorked * hourlyPayRate;
        }

        //Method ToString
        public override string ToString()

        {
            return "\nDisplaying employee information" +
                            "\nEmployee Name: " + employeeName +
                            "\nEmployee Number: " + employeeNumber +
                            "\nDepartment: " + department +
                            "\nHourly Pay Rate: " + hourlyPayRate.ToString("C2") +
                            "\nEmployee Salary: " + CalculateGrossPay().ToString("C2");
        }
    }
}
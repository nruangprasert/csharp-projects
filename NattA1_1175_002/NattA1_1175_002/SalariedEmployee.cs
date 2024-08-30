using System;

namespace NattA1_1175_002
{
    internal class SalariedEmployee
    {
        //Instancd variables
        private string salEmployeename;
        private int salEmployeeNumber;
        private double monthlySalary;
        private double overtimeHours;

        //Default constructor
        public SalariedEmployee()
        {

        }

        //Parameterized constructor
        public SalariedEmployee(string salEmployeename, int salEmployeeNumber, double monthlySalary, double overtimeHours)
        {
            this.salEmployeename = salEmployeename;
            this.salEmployeeNumber = salEmployeeNumber;
            this.monthlySalary = monthlySalary;
            this.overtimeHours = overtimeHours;
        }

        //Properties
        public string SalEmployeename
        {
            get; set;
        }
        public string SalEmployeeNumber
        {
            get; set;
        }
        public string MonthlySalary
        {
            get; set;
        }
        public string OvertimeHours
        {
            get; set;
        }

        //Method CalculateSalary
        public double CalculateSalary()
        {
            const double overtimeRate = 45;
            return monthlySalary + (overtimeHours * overtimeRate);
        }

        //Method ToString
        public override string ToString()
        {
            return "\nDisplaying salaried employee information" +
                            "\nEmployee Name: " + salEmployeename +
                            "\nEmployee Number: " + salEmployeeNumber +
                            "\nOvertime hours: " + overtimeHours +
                            "\nSalary per month: " + monthlySalary.ToString("C2") +
                            "\nSalary including overtime: " + CalculateSalary().ToString("C2");
        }
    }
}
using System;

namespace NattA1_1175_002
{
    internal class CommissionedEmployee
    {
        //Instance variables
        private string commEmployeeName;
        private int commEmployeeNumber;
        private double commRate;
        private double commWeeklySales;

        //Default constructor
        public CommissionedEmployee()
        {
        }

        //Parameterized constructor
        public CommissionedEmployee(string commEmployeeName, int commEmployeeNumber, double commRate, double commWeeklySales)
        {
            this.commEmployeeName = commEmployeeName;
            this.commEmployeeNumber = commEmployeeNumber;
            this.commRate = commRate;
            this.commWeeklySales = commWeeklySales;
        }

        //Properties
        public string CommEmployeeName
        {
            get; set;
        }
        public int CommEmployeeNumber
        {
            get; set;
        }
        public double CommRate
        {
            get; set;
        }
        public double CommWeeklySales
        {
            get; set;
        }

        //Method CalculateGrossPay
        public double CalculateGrossPay()
        {
            return commRate / 100 * commWeeklySales;
        }

        //Method CalculateFedTax
        public double CalculateFedTax()
        {
            const double federalTaxRate = 0.12;
            return CalculateGrossPay() * federalTaxRate;
        }

        //Method CalculateSoSecDed
        public double CalculateSoSecDed()
        {
            const double socialSecurityTaxRate = 0.05;
            return CalculateGrossPay() * socialSecurityTaxRate;
        }

        //Method CalculateDeduction
        public double CalculateDeduction()
        {
            return CalculateFedTax() + CalculateSoSecDed();
        }

        //Method CalculateTakeHomePay
        public double CalculateTakeHomePay()
        {
            return CalculateGrossPay() - CalculateDeduction();
        }

        //Method ToString
        public override string ToString()
        {
            return "\nDisplaying commissioned employee information" +
                            "\nEmployee Name: " + commEmployeeName +
                            "\nEmployee Number: " + commEmployeeNumber +
                            "\nWeekly Sales: " + commWeeklySales.ToString("C2") +
                            "\nGross Pay: " + CalculateGrossPay().ToString("C2") +
                            "\nFed. Taxes: " + CalculateFedTax().ToString("C2") +
                            "\nSoc.Sec.:  " + CalculateSoSecDed().ToString("C2") +
                            "\n" +
                            "\nTotal Deductions: " + CalculateDeduction().ToString("C2") +
                            "\nTake-home Pay: " + CalculateTakeHomePay().ToString("C2");
        }
    }
}
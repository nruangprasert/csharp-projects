using System;
namespace EmployeeChapter05
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private int iD;
        private char type;
        private double salaryAmount;
        private double grossPay;
        private double hoursWorked;
        private double hourlyPayRate;
        private double federalTax;
        private double socialSecurity;
        private double retirementContribution;
        private double totalDeductions;
        private double takeHomePay;
    
        public Employee()
        {

        }
        public Employee(string firstName, string lastName, int iD, char type, double salaryAmount)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.iD = iD;
            this.type = type;
            this.salaryAmount = salaryAmount;
        }
        public Employee(string firstName, string lastName, int iD, char type, double hoursWorked, double hourlyPayRate) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.iD = iD;
            this.type = type;
            this.hoursWorked = hoursWorked;
            this.hourlyPayRate = hourlyPayRate;
        }
        public double GrossPay { get; set; }
        public double FederalTax { get; set; }
        public double SocialSecurity { get; set; }
        public double RetirementContribution { get; set; }
        public double TotalDeductions { get; set; }
        public double TakeHomePay { get; set; }
        public double CalculateS() 
        {
            return this.salaryAmount;
        }
        public double CalculateH()
        {
            if (hoursWorked > 40) 
            {
                grossPay = (40 * hourlyPayRate) + ((hoursWorked - 40) * (1.5 * hourlyPayRate));
                return grossPay;
            }
            else
            {
                grossPay = (hoursWorked * hourlyPayRate);
                return grossPay;
            }
        }
        public void CalculateDeductions(double grossPay, out double federalTax, out double socialSecurity, 
            out double retirementContribution, out double totalDeductions, out double takeHomePay) 
        {
            federalTax = 0.18 * grossPay;
            socialSecurity = 0.06 * grossPay;
            retirementContribution = 0.10 * grossPay;
            totalDeductions = federalTax + socialSecurity + retirementContribution;
            takeHomePay = grossPay - totalDeductions;
        }
        public override string ToString()
        {
            return "\nWeekly information for " + firstName + " " + lastName +
                    "\n" +
                    "\n" + string.Format("{0,-35}", "Employee ID:") + iD +
                    "\n" + string.Format("{0,-35}", "Gross pay:") + GrossPay.ToString("C2") +
                    "\n" + string.Format("{0,-35}", "Federal tax paid:") + FederalTax.ToString("C2") +
                    "\n" + string.Format("{0,-35}", "Social security paid:") + SocialSecurity.ToString("C2") +
                    "\n" + string.Format("{0,-35}", "Retirement contribution:") + RetirementContribution.ToString("C2") +
                    "\n" + string.Format("{0,-35}", "Total deductions:") + TotalDeductions.ToString("C2") +
                    "\n" +
                    "\n" + string.Format("{0,-35}", "Take home pay:") + TakeHomePay.ToString("C2");
        }
    }

}

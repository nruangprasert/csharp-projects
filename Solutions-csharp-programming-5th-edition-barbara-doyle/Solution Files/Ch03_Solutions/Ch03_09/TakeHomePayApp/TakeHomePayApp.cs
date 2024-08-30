/* TakeHomePayApp.cs
 * This application calculates
 * take home pay based using a constant commission 
 * rate. Users are asked to input name and weekly sales.
 * Federal taxes, social security taxes, 
 * retirement fund contributions are calculated. Take
 * home pay subtracts out these deductions.
 */

using System;
using static System.Console;

namespace TakeHomePayApp
{
    class TakeHomePayApp
    {
        static void Main( )
        {
            const double COMMISSION_RATE = 0.07;
            const double FEDERAL_TAX_RATE = 0.18;
            const double SOCIAL_SECURITY_RATE = 0.09;
            const double RETIREMENT_CONTRIBUTION = 0.15;

            string employeeName;
            double weeklySales,
                    grossPay,
                    retirementContribution,
                    fedTax,
                    socSecurityTax,
                    netPay;

            DisplayInstructions();
            employeeName = GetInfo("an employee name");
            weeklySales = double.Parse(GetInfo("this employee's weekly sales"));
            grossPay = CalculateGrossPay(weeklySales, COMMISSION_RATE);
            retirementContribution = CalculateRetirementPaid(grossPay, RETIREMENT_CONTRIBUTION);
            fedTax = CalculateFedTaxesPaid(grossPay, FEDERAL_TAX_RATE);
            socSecurityTax = CalculateSocSecPaid(grossPay, SOCIAL_SECURITY_RATE);
            netPay = CalculateTakeHomePay(grossPay, retirementContribution, fedTax, socSecurityTax);
            DisplayResults(employeeName, weeklySales, grossPay, retirementContribution, fedTax, socSecurityTax, netPay,
                            COMMISSION_RATE, FEDERAL_TAX_RATE, SOCIAL_SECURITY_RATE, RETIREMENT_CONTRIBUTION);
            ReadKey();
        }

        static void DisplayInstructions()
        {
            Write("You will be asked to enter the name of an employee\n"
               + "and his weekly sales. Calculations will be performed to \n"
               + "determine his deductions and take home pay.\n\n");
        }

        static string GetInfo(string info)
        {
            Write("Please enter {0}: ", info);
            return (ReadLine());
        }

        static void DisplayResults(string employeeName, double weeklySales, double grossPay, 
                                    double retirementContribution, double fedTax, double socSecurityTax,
                                    double netPay, double COMMISSION_RATE, double FEDERAL_TAX_RATE, 
                                    double SOCIAL_SECURITY_RATE, double RETIREMENT_CONTRIBUTION)
        {
            Clear();
            WriteLine("\tWeekly Payroll App");
            WriteLine("\n{0}{1}", "Employee Name: ", employeeName);
            WriteLine("\n\n{0,-30}{1,12:C}", "This week\'s Sales:", weeklySales);
            WriteLine("Commission Rate: {0:F2}", COMMISSION_RATE);
            WriteLine("\n{0,-30}{1,12:C}", "Gross Pay: ",
                CalculateGrossPay(weeklySales, COMMISSION_RATE));
            WriteLine("{0,-25}({1:P0}):{2,10:C}",
                "Federal Taxes Withheld: ", FEDERAL_TAX_RATE, fedTax);
            WriteLine("{0,-25}({1:P0}):{2,11:C}",
                "Soc. Sec. Taxes Withheld ", SOCIAL_SECURITY_RATE, socSecurityTax);
            WriteLine("{0,-25}({1:P0}):{2,10:C}",
                "Retirement Contribution: ", RETIREMENT_CONTRIBUTION, retirementContribution);
            WriteLine("\n{0,-30}{1,12:C}",
                "Total Deductions: ", CalculateTotalDeductions(retirementContribution, fedTax, socSecurityTax));
            WriteLine("\n{0,-30}{1,12:C}",
                "Take Home Pay: ", netPay);
        }
        
        static double CalculateGrossPay(double weeklySales, double COMMISSION_RATE)
        {
            return weeklySales * COMMISSION_RATE;
        }

        static double CalculateFedTaxesPaid(double grossPay, double FEDERAL_TAX_RATE)
        {
            return grossPay * FEDERAL_TAX_RATE;

        }

        static double CalculateSocSecPaid(double grossPay, double SOCIAL_SECURITY_RATE)
        {
            return grossPay * SOCIAL_SECURITY_RATE;
        }

        static double CalculateRetirementPaid(double grossPay, double RETIREMENT_CONTRIBUTION)
        {
            return grossPay * RETIREMENT_CONTRIBUTION;
        }

        static double CalculateTotalDeductions(double retirementContribution, double fedTax, double socSecurityTax)
        {
            return retirementContribution + fedTax + socSecurityTax;
        }

        static double CalculateTakeHomePay(double grossPay, double retirementContribution, double fedTax, double socSecurityTax)
        {
            return grossPay - retirementContribution - fedTax - socSecurityTax;
        }
    }
}

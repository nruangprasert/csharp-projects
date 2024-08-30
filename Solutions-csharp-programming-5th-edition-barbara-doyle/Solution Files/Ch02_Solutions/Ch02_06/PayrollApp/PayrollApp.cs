/* PayrollApp.cs 
 * This program calculates take home pay based on 
 * commission rate, weekly sales, tax rate,
 * social security rate, and retirement fund 
 * contribution rate. It provides practice declaring
 * constants and using the currency format specifier.
 */

using System;
using static System.Console;

namespace PayrollApp
{
    class PayrollApp
    {
        static void Main( )
        {
            const decimal COMMISSION_RATE = 0.07M;
            const decimal FEDERAL_TAX_RATE = 0.18M;
            const decimal SOCIAL_SECURITY_RATE = 0.06M;
            const decimal RETIREMENT_CONTRIBUTION = 0.10M;

            string employeeName = "Joshua Montain";
            decimal monthlySales = 161432.00M;
            decimal    grossPay,
                       fedTaxPaid,
                       socSecPaid,
                       retirementPaid,
                       totalDeductions,
                       takeHomePay;

            grossPay = monthlySales * COMMISSION_RATE;
            fedTaxPaid = grossPay * FEDERAL_TAX_RATE;
            socSecPaid = grossPay * SOCIAL_SECURITY_RATE;
            retirementPaid = grossPay * RETIREMENT_CONTRIBUTION;
            totalDeductions = fedTaxPaid + socSecPaid + retirementPaid;
            takeHomePay = grossPay - totalDeductions;

            WriteLine("\t{0,-12}{1,-25}", "Employee:  ", employeeName);
            WriteLine("{0,-28}{1,15:C}", "Total Sales: ", monthlySales);
            WriteLine("{0,-9} ({1,-2:P0}): {2,26:N2}", "Gross Pay", COMMISSION_RATE, grossPay);
            WriteLine("{0,-28}{1,15:N2}", "Federal Taxes:  ", fedTaxPaid);
            WriteLine("{0,-28}{1,15:N2}", "Social Security Taxes:  ", socSecPaid);
            WriteLine("{0,-28}{1,15:N2}", "Retirement Contribution:  ", retirementPaid);
            WriteLine("{0,-28}{1,15:N2}", "", "-----------");
            WriteLine("{0,-28}{1,15:N2}", "Total Deductions:  ", totalDeductions);
            WriteLine();
            WriteLine("{0,-28}{1,15:C}", "Take Home Pay:  ", takeHomePay);
            ReadKey();
        }
    }
}

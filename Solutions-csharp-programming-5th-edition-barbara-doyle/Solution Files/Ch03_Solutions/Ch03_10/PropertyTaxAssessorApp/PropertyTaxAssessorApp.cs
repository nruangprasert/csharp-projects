/* PropertyTaxAssessorApp
   This application calculates property
   taxes, giving a $25,000 exemption and
   basing taxes on a $10.03 per thousand millage rate.
*/
using System;
using static System.Console;

namespace PropertyTaxAssessorApp
{
    class PropertyTaxAssessorApp
    {
        static void Main( )
        {
            const double MILLAGE_RATE = 10.03;
            const double ASSESSMENT_INCREASE = 0.027;
            const double EXEMPTION = 25000;

            string propertyAddress;
            double lastYearValue,
                   thisYearValue,
                   taxesDue;

            DisplayInstructions(MILLAGE_RATE, EXEMPTION);
            propertyAddress = GetAddress();
            lastYearValue = GetValue();
            thisYearValue = CalculateNewAssessedValue(lastYearValue, ASSESSMENT_INCREASE);
            taxesDue = CalculateTaxesDue(thisYearValue, EXEMPTION, MILLAGE_RATE);
            DisplayResults(propertyAddress, lastYearValue, thisYearValue, MILLAGE_RATE, EXEMPTION, taxesDue);
            ReadKey();
        }

        static void DisplayInstructions(double MILLAGE_RATE, double EXEMPTION)
        {
            WriteLine("This application determines taxes due for this calendar year.");
            WriteLine("You will be asked to enter the property address and your \n" +
                                "assessed value for last year.\n\nTaxes are based on the following:");
            WriteLine("Mileage Rate: {0:C} (per $1,000 of taxable value).", MILLAGE_RATE);
            WriteLine("{0:C} (exemption): subtracted from taxable values for homeowners.", EXEMPTION);
            WriteLine("\n\n\tPress any key when you are ready to begin....");
            ReadKey();
            Clear();
        }

        static string GetAddress()
        {
            Write("Please enter the property\'s Street Address: ");
            return ReadLine();
        }

        static double GetValue()
        {
            Write("Please enter the assessed value for last year: ");
            return double.Parse(ReadLine());
        }

        static double CalculateNewAssessedValue(double lastYearValue, double ASSESSMENT_INCREASE)
        {
            return lastYearValue * (1 + ASSESSMENT_INCREASE);
        }

        static double CalculateTaxesDue(double thisYearValue, double EXEMPTION, double MILLAGE_RATE)
        {
            return (thisYearValue - EXEMPTION) / 1000 * MILLAGE_RATE;
        }

        static void DisplayResults(string propertyAddress, double lastYearValue, double thisYearValue, double MILLAGE_RATE,
                                              double EXEMPTION, double taxesDue)
        {
            Clear();
            WriteLine("\tProperty Assessment App");
            WriteLine("\nStreet Address: {0}", propertyAddress);
            WriteLine("\n{0,-28}{1,12:C}", "Last Year Assessed Value:", lastYearValue);
            WriteLine("\n{0,-28}{1,12:C}", "Current Assessed Value:", thisYearValue);
            WriteLine("{0,-28}{1,12:C}", "Exemption:", EXEMPTION);
            WriteLine("{0,-28}{1,12:C}", "Taxable Value:", (thisYearValue - EXEMPTION));
            WriteLine("\n{0,-28}{1,12:C}", "Mileage Rate (per $1,000):", MILLAGE_RATE);
            WriteLine("\n{0,-28}{1,12:C}", "Taxes Due:", taxesDue);
        }
    }
}

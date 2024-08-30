using System;

namespace ConsoleApp1
{
    class Method01
    {
        static void Main(string[] args)
        {
            
            Input(out string name, out double salesAmount);
            
            Calculate(ref salesAmount, out double salesCommissionActual, out double federalTaxActual,
             out double retirementContributionActual, out double socialSecurityActual, out double takehome);

            Display(ref name, ref salesCommissionActual, ref federalTaxActual, ref retirementContributionActual,
                ref socialSecurityActual, ref takehome);

            Console.ReadKey();
        }

        static void Input(out string name, out double salesAmount)
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your sales amount of the week: ");
            salesAmount = double.Parse(Console.ReadLine());
        }
        
        
        static void Calculate(ref double salesAmount, out double salesCommissionActual, out double federalTaxActual,
             out double retirementContributionActual, out double socialSecurityActual, out double takehome)
        {
            const double salesCommissionRate = 0.07;
            const double federalTaxRate = 0.18;
            const double retirementContribution = 0.15;
            const double socialSecurityTaxRate = 0.09;
            
            salesCommissionActual = salesAmount* salesCommissionRate;
            federalTaxActual = salesCommissionActual * federalTaxRate;
            retirementContributionActual = salesCommissionActual * retirementContribution;
            socialSecurityActual = salesCommissionActual * socialSecurityTaxRate;
            takehome = salesCommissionActual - federalTaxActual - retirementContributionActual
                - socialSecurityActual;
        }
        static void Display(ref string name, ref double salesCommissionActual, ref double federalTaxActual, 
            ref double retirementContributionActual,
                ref double socialSecurityActual, ref double takehome)
        {
            Console.WriteLine(name);
            Console.WriteLine(salesCommissionActual);
            Console.WriteLine(federalTaxActual);
            Console.WriteLine(retirementContributionActual);
            Console.WriteLine(socialSecurityActual);
            Console.WriteLine(takehome);
           
        }

    }
}

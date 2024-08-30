using System;

namespace ConsoleApp1
{
    class Method01
    {
        static void Main(string[] args)
        {
            double amountBeforeTaxM = InputCharge();

            //Use ref to send amountBeforeTaxM to Calculate method. No double required here.
            Calculate(ref amountBeforeTaxM, out double OnlyTax, out double amountAfterTax, out double OnlyTip15,
            out double OnlyTip20, out double amountPlusTip15, out double amountPlusTip20);

            double OnlyTaxM = OnlyTax;
            double amountAfterTaxM = amountAfterTax;
            double OnlyTip15M = OnlyTip15;
            double OnlyTip20M = OnlyTip20;
            double amountPlusTip15M = amountPlusTip15;
            double amountPlusTip20M = amountPlusTip20;

            Display(amountBeforeTaxM, OnlyTaxM, amountAfterTaxM, OnlyTip15M,
            OnlyTip20M, amountPlusTip15M, amountPlusTip20M);
           
            Console.ReadKey();

        }
        
        static double InputCharge()
        {
            Console.Write("Please enter the amount before tax: ");
            double amountBeforeTaxI = double.Parse(Console.ReadLine());
            return amountBeforeTaxI;
        }
        
        //Use ref to receive amountBeforeTaxM to Calculate method. No double required here.
        static void Calculate(ref double amountBeforeTaxC, out double OnlyTax, out double amountAfterTax, out double OnlyTip15,
           out double OnlyTip20, out double amountPlusTip15, out double amountPlusTip20)
        {
            
            OnlyTax = 0.09 * amountBeforeTaxC;
            amountAfterTax = amountBeforeTaxC + OnlyTax;
            OnlyTip15 = 0.15 * amountAfterTax;
            OnlyTip20 = 0.20 * amountAfterTax;
            amountPlusTip15 = amountAfterTax + OnlyTip15;
            amountPlusTip20 = amountAfterTax + OnlyTip20;
        }
        static void Display(double amountBeforeTaxD, double OnlyTaxD, double amountAfterTaxD, double OnlyTip15D,
            double OnlyTip20D, double amountPlusTip15D, double amountPlusTip20D)
        {
            Console.WriteLine(amountBeforeTaxD);
            Console.WriteLine(OnlyTaxD);
            Console.WriteLine(amountAfterTaxD);
            Console.WriteLine(OnlyTip15D);
            Console.WriteLine(OnlyTip20D);
            Console.WriteLine(amountPlusTip15D);
            Console.WriteLine(amountPlusTip20D);
        }

    }
}

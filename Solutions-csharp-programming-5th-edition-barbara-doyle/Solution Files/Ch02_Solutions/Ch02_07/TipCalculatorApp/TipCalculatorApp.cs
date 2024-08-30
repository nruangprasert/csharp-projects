/*TipCalculatorApp
 * This application determines the tip amount that 
 * should be added to a restaurant charge. 
 * Output is produced showing the tips and total
 * charges for both 15% and 20%. 
 */
using System;
using static System.Console;

namespace TipCalculatorApp
{
    class TipCalculatorApp
    {
        static void Main( )
        {
            const double SMALL_TIP = 0.15;
            const double LARGER_TIP = 0.20;

            double totalBeforeTip,
                   smallTipAmount,
                   largerTipAmount;

            totalBeforeTip = 42.00;
            smallTipAmount = totalBeforeTip * SMALL_TIP;
            largerTipAmount = totalBeforeTip * LARGER_TIP;
            WriteLine("\tTip Calculator App\n");
            WriteLine("{0,-15} {1,11:C}", "Sub-total Before Tip:", totalBeforeTip);
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine("\n{0,3:P0}  Tip: {1,22:C}", SMALL_TIP, smallTipAmount);
            WriteLine("\n{0,35}", "--------");
            WriteLine("Total including {0:P0} Tip:{1,8:C}", SMALL_TIP,
                                (totalBeforeTip + smallTipAmount));            
            WriteLine();
            WriteLine();
            WriteLine();
            WriteLine("\n{0,3:P0}  Tip: {1,22:C}", LARGER_TIP, largerTipAmount);
            WriteLine("\n{0,35}", "--------");
            WriteLine("Total including {0:P0} Tip:{1,8:C}", LARGER_TIP,
                                (totalBeforeTip + largerTipAmount));
            ReadKey();
        }
    }
}

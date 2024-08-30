using System;
using static System.Console;

namespace CalculateChangeCoins
{
    class CalculateChangeCoins
    {
        static void Main( )
        {
            const int AMOUNT_DUE = 92;
            int leftOverChange,
                quartersDue,
                dimesDue,
                nickelsDue,
                penniesDue;

            leftOverChange = AMOUNT_DUE;
            quartersDue = leftOverChange / 25;
            leftOverChange = leftOverChange % 25;
            dimesDue = leftOverChange / 10;
            leftOverChange = leftOverChange % 10;
            nickelsDue = leftOverChange / 5;
            penniesDue = leftOverChange % 5;

            WriteLine("\tChanger App");

            WriteLine("Change Amount: {0,4:f2}" +
                      "\n\nQuarters: {1,2:f0}" +
                      "\nDimes: {2,5:f0}\nNickels {3,4:f0}" +
                      "\nPennies: {4,3:f0}",
                      ((double)AMOUNT_DUE / 100), quartersDue, dimesDue,
                      nickelsDue, penniesDue);
            ReadKey();
        }
    }
}

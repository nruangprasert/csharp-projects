/* LocalAreaCodeApp.cs
 * This class tests the LocalAreaCode class by instantiating
 * objects of the class and invoking its methods.
 */
using System;
using System.Console;

namespace LocalAreaCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] flAreaCodes = {305, 321, 352, 386, 407, 561, 727, 
                               754, 772, 786, 813, 850, 863, 904, 941, 954 };
            int[] caAreaCodes = {209, 213, 310, 323, 408, 415, 510,
                                  530, 559, 562, 619, 626, 650, 661,
                                  707, 714, 760, 805, 818, 831, 858, 
                                  909, 916, 925, 949};
            int[] iowaCodes = {515, 563, 319, 641, 712 }; // Test of codes out of order

            LocalAreaCode floridaExchange = new LocalAreaCode(flAreaCodes);
            LocalAreaCode califExchange = new LocalAreaCode(caAreaCodes);
            LocalAreaCode iowaExchange = new LocalAreaCode(iowaCodes);

            WriteLine("List of Florida Area Codes\n" + floridaExchange);
            WriteLine("Area Code 399 in Florida? " + floridaExchange.ValidStateCode(399));
            WriteLine("Area Code 850 in Florida? " + floridaExchange.ValidStateCode(850));
            WriteLine("\n\n\nList of California Area Codes\n" + califExchange);
            WriteLine("Area Code 559 in California? " + califExchange.ValidStateCode(559));
            WriteLine("Area Code 560 in California? " + califExchange.ValidStateCode(560));
            WriteLine("\n\n\nList of Iowa Area Codes\n" + iowaExchange);
            WriteLine("Area Code 559 in Iowa? " + iowaExchange.ValidStateCode(559));
            ReadKey();
        }
    }
}

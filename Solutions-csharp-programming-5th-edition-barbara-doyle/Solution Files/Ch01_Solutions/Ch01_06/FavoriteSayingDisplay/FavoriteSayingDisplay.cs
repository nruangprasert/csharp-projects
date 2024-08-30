/* FavoriteSayingDisplay
 * This application displays a favorite saying three ways
 * giving practice using Write( ) method. With the third
 * printing, practice is given making a choice regarding 
 * invoking the WriteLine( ) versus Write( ) method.
*/

using System;
using static System.Console;

namespace FavoriteSayingDisplay
{
    class FavoriteSayingDisplay
    {
        static void Main( )
        {
            WriteLine("\n\tOutput #1");
            Write("\t\tLaugh often, ");
            Write("Dream big, ");
            Write("Reach for the stars!");

            WriteLine();
            WriteLine();
            WriteLine("\tOutput #2");
            Write("\t\tLaugh often,  \n");
            Write("\t\tDream big, \n");
            Write("\t\tReach for the stars!");

            WriteLine();
            WriteLine();
            WriteLine("\tOutput #3");
            WriteLine("\t\tLaugh");
            WriteLine("\t\toften,");
            WriteLine("\t\tDream ");
            WriteLine("\t\tbig,");
            WriteLine("\t\tReach");
            WriteLine("\t\tfor");
            WriteLine("\t\tthe");
            WriteLine("\t\tstars!");
            ReadKey();
        }
    }
}

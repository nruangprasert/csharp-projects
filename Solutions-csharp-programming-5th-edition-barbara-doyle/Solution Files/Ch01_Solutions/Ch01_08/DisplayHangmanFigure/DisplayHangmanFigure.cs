/* DisplayHangmanFigure.cs 
 * This program displays a stick figure.
 * It gives practice creating output and
 * working with escape characters.
 */

using System;
using static System.Console;

namespace DisplayHangmanFigure
{    class DisplayHangmanFigure
    {
        static void Main( )
        {
            WriteLine("\n      (^;^)");
            WriteLine("\n        |");
            WriteLine("\n      ./|\\.");
            WriteLine("\n        |");
            WriteLine("\n      _/ \\_");
            ReadKey();
        }
    }
}

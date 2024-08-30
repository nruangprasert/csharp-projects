/* DisplayInfoApp.cs
 * This application produces a listing with
 * information such as your name, hometown, major, 
 * hobby and/or favorite activity. The listing is
 * placed on a single line with each entry 
 * separated by backslashes.
 */

using System;
using static System.Console;

namespace DisplayInfoApp
{
    class DisplayInfoApp
    {
        static void Main( )
        {
			Write("\n");
			Write("  *********************************************\n");
			Write("  *|\tName: Barbara Doyle\\                  *\n");
			Write("  *\tHometown: Jacksonville\\               *\n");
			Write("  *\tMajor: CS\\                            *\n");
			Write("  *\tHobby: Biking\\                        *\n");
			Write("  *\tFavorite Activity: Swimming\\         |*\n");
            Write("  *********************************************");
            ReadKey();
        }
    }
}

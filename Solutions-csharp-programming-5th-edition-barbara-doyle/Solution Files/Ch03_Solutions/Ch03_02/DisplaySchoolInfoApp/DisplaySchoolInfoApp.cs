/* DisplaySchoolInfo.cs
 * This application displays information
 * about your school. Practice is giving writing
 * and invoking methods.
 */
using System;
using static System.Console;

namespace DisplaySchoolInfoApp
{
    class DisplaySchoolInfoApp
    {
        static void Main( )
        {
            string schoolInfo;

            DisplayAsterisks();
            schoolInfo = RetrieveSchoolInfo();
            WriteLine(schoolInfo);
            DisplayAsterisks();

            ReadKey();
        }

        static void DisplayAsterisks()
        {
            WriteLine("*************************************");
        }

        static string RetrieveSchoolInfo()
        {
            string returnValue;
            returnValue = "\tTrent University\n" +
                          " School Colors: Red/Black\n" +
                          " Mascot: Dolphin\n" +
                          " Location: Williamsburg New Jersey\n" +
                          " Number of Students: 27,000";
            return returnValue;
        }
    }
}
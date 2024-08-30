/* DateApp.cs
 * This class tests the Date class.
 */

using System;
using static System.Console;

namespace DateApp
{
    class DateApp
    {
        static void Main(string[] args)
        {
            Date aDate = new Date();
            aDate.Month = AskForInput("Month");
            aDate.Day = AskForInput("Day");
            aDate.Year = AskForInput("Year");
            
            Clear();
            WriteLine("\tFirst Test");
            WriteLine(aDate);

            Date secondDate = new Date();
            secondDate.Month = 3;
            secondDate.Day = 20;
            secondDate.Year = 2010;
            WriteLine("\n\tSecond Test: ");
            WriteLine(secondDate);

            WriteLine("\n\tThird Test ");
            Date anotherDate = new Date(2, 2, 2016);
            WriteLine("Date: " + anotherDate.ToString());

            WriteLine("\n\tLast Test ");
            Date lastOne = new Date("October", 3, 2017);
            WriteLine(lastOne.ReturnLongDate());

            ReadKey();
        }

        static int AskForInput(string whichOne)
        {
            string inValue;
            Write("Enter a number representing the {0}: ", whichOne);
            inValue = ReadLine();
            return (int.Parse(inValue));
        }
    }
}

using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Chapter04Question01
{
    internal class DateApp
    {
        static void Main(string[] args)
        {
            int year = ReceiveInt("year");
            int month = ReceiveInt("month");
            int day = ReceiveInt("day");

            Date date = new Date(year, month, day);
            Console.WriteLine(date);
            Console.ReadKey();
        }
        static int ReceiveInt(string value)
        {
            Console.Write($"Enter {value} : ");
            int input = int.Parse(Console.ReadLine());
            return input;
        }
       
    }
}

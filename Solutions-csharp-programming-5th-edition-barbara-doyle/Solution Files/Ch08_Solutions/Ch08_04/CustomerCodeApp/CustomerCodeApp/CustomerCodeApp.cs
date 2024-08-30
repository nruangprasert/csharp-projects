/* This class test the CustomerCode class. It enables users
 * to input full name (first name entered first), birthdate (mm/dd/yyyy),
 * month (number) they purchased a subscription,  and zip code. These
 * values are used to instantiate an object of the CustomerCode class.
*/
using System;
using static System.Console;

namespace CustomerCodeApp
{
    class CustomerCodeApp
    {
        static void Main(string[] args)
        {
            string fullname,
                   zip,
                   birthDate;
            int subMonth;

            fullname = GetInputData("name (first name, space, and last name)");
            zip = GetInputData("postal zip code");
            birthDate = GetInputData("birth date (mm/dd/yyyy)");
            subMonth = int.Parse(GetInputData("month number you purchased the subscription (mm)"));

            CustomerCode firstTest = new CustomerCode(fullname, birthDate, zip, subMonth);
            WriteLine("\n\n testing...");
            WriteLine("\n\nFirst Mail Label Code: {0}\n", firstTest.ToString());

            CustomerCode secondTest = new CustomerCode("Belinda Rivers", "03/29/1994", "32211", 6);
            WriteLine("Second Mail Label Code: {0}\n", secondTest);

            CustomerCode thirdTest = new CustomerCode("Chinsoo Wong", "10/29/1995", "43231", 5);
            WriteLine("Third Mail Label Code: {0}\n", thirdTest);

            CustomerCode anotherTest = new CustomerCode("Duncan Samilson", "06/19/1992", "43167", 1);
            WriteLine("Another Mail Label Code: {0}\n", anotherTest);

            CustomerCode lastTest = new CustomerCode("Bob Clocksom", "01/22/1993", "32226", 10);
            WriteLine("Last Mail Label Code: {0}\n", lastTest);

            ReadKey();
        }

        public static string GetInputData(string whatinput)
        {
            Write("Please enter the {0}: ", whatinput);
            return ReadLine();
        }
    }
}

using System;

namespace Chapter04Question07
{
    internal class ParkApp
    {
        static void Main(string[] args)
        {
        string nameOfPark = ReceiveString("name of the park");
        string location = ReceiveString("location");
        string typeOfPark = ReceiveString("type of the park");
        string facility = ReceiveString("facility");
        double fee = ReceiveDouble("fee");
        int numberOfEmployees = ReceiveInt("number of employees");
        int numberOfVisitors = ReceiveInt("number of visitors");
        double annualBudget = ReceiveDouble("annual budget");
        
        Park park = new Park(nameOfPark, location, typeOfPark, facility, fee, numberOfEmployees, numberOfVisitors, annualBudget);
            Console.WriteLine(park.Return01());
            Console.WriteLine(park.Return02());
            Console.WriteLine(park.Return03());
            Console.WriteLine(park.Return04());
            Console.WriteLine(park.ToString());

            Console.ReadKey();

        }
        

        static string ReceiveString(string value)
        {
            Console.Write($"Enter {value} : ");
            return Console.ReadLine();
        }
        static double ReceiveDouble(string value)
        {
            Console.Write($"Enter {value} : ");
            return double.Parse(Console.ReadLine());
        }
        static int ReceiveInt(string value)
        {
            Console.Write($"Enter {value} : ");
            return int.Parse(Console.ReadLine());
        }

    }
}
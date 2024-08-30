/*TripApp.cs
 *This class tests the Trip class. 
 *It allows users to input destination traveled and
 *fuel consumed.
 */

using System;
using static System.Console;

namespace TripApp
{
    class TripApp
    {
        static void Main(string[] args)
        {
            
            Trip aTrip = new Trip();
            aTrip.Destination = AskForDestination();
            aTrip.DistanceTraveled = AskForMilesTraveled();
            aTrip.GallonsConsumed = AskForFuelConsumed();
            aTrip.FuelCost = AskForFuelCost();

            Clear();
            WriteLine(aTrip);

            WriteLine("\n\n");
            Trip anotherTrip = new Trip("Atlanta", 600, 120, 45);
            WriteLine(anotherTrip);

            WriteLine("\n\n");
            Trip lastTrip = new Trip("Boston", 300);
            lastTrip.FuelCost = 90;
            lastTrip.GallonsConsumed = 26;
            WriteLine(lastTrip);
            ReadKey();
        }

        static string AskForDestination()
        {
            string inValue;
            Write("Enter Trip Destination: ");
            inValue = ReadLine();
            return inValue;
        }

        static double AskForMilesTraveled()
        {
            string inValue;
            double miles;
            Write("Enter Miles Traveled: ");
            inValue = ReadLine();
            miles = double.Parse(inValue);
            return miles;
        }

        static double AskForFuelConsumed()
        {
            string inValue;
            double fuel;
            Write("Enter Gallons: ");
            inValue = ReadLine();
            fuel = double.Parse(inValue);
            return fuel;
        }
        static double AskForFuelCost()
        {
            string inValue;
            double cost;
            Write("Enter Total Fuel Cost: ");
            inValue = ReadLine();
            cost = double.Parse(inValue);
            return cost;
        }
    }
}

/* ParksApp.cs
 * This application tests the instance methods
 * and properties of the Park class.
 */

using System;
using static System.Console;

namespace ParksApp
{
    public class ParksApp
    {
        public static void Main(string[] args)
        {
            Park huegonot = new Park("Heugonot", "Kerry GA", 3.00);
            Park yulie = new Park("Yulie", "Wyoming", "National", "camping", 5.00, 500, 100000, 750000);
            Park Aster = new Park();

            WriteLine(yulie);
            WriteLine("Revenue From Fees: " + yulie.ComputeRevenueFromFees().ToString("C"));
            WriteLine("Cost Per Visitor: "  + yulie.CalculateCostPerVisitor().ToString("C"));

            WriteLine();
            WriteLine();
            huegonot.FacilitiesAvailable = "Hiking, Biking, Camping";
            WriteLine(huegonot.ParkFacilities());

            WriteLine();
            WriteLine();
            Aster.ParkName = "Aster Regional Park";
            Aster.ParkLocation = "Maine";
            Aster.TypeOfPark = "Local";
            WriteLine(Aster.WhichPark());

            ReadKey();
        }
    }
}

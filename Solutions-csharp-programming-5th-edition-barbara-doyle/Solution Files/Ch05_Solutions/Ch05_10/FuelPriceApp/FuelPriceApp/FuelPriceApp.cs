/* FuelPriceApp.cs
 * This application allows the user to input two
 * fuel prices, one in price per liter and the other
 * in price per gallons. A decision is made as to 
 * which station offers the most economical fuel price.
 */
using System;
using static System.Console;

namespace FuelPriceApp
{
    class FuelPriceApp
    {
        static void Main(string[] args)
        {
            double pricePerLiter,
                   pricePerGallon,
                   comparablePricePerGallon;

            DisplayInstructions();
            pricePerLiter = GetInput("Canadian liter");
            pricePerGallon = GetInput("American gallon");

            comparablePricePerGallon = ConvertLitersToGallons(pricePerLiter);
            DisplayResults(pricePerLiter, pricePerGallon, comparablePricePerGallon);
            ReadKey();
       }

        public static void DisplayInstructions()
        {
            WriteLine("Which gas station should be used?\n" +
                      "\nThe first value entered is price per liter at the Canadian station." +
                      "\nThe second value entered is the price per gallon at the American station." +
                      "\n\nA decision is made as to which station offers the most economical fuel price.");
            WriteLine("\n\nPress any key when you are ready to begin...");
            ReadKey();
            Clear();
        }


        public static double GetInput(string whichOne)
        {
            double price;
            Write("Please enter the price per {0}: ", whichOne);
            if (double.TryParse(ReadLine( ), out price) == false)
                WriteLine("Invalid data entered - 0 recorded for price");
            return price;
        }

        // To convert from liters to gallons, multiply the number of liters by 3.7854
        public static double ConvertLitersToGallons(double pricePerLiter)
        {
            return pricePerLiter * 3.7854;
        }

        public static void DisplayResults(double pricePerLiter, double pricePerGallon, double comparablePricePerGallon)
        {
            Clear( );
            WriteLine("\tWhich station has the best fuel prices?");
            WriteLine("\nAmerican Station - Price per gallon: {0:C}", pricePerGallon);
            WriteLine("Canadian Station - Price per liter: {0:C}", pricePerLiter);
            Write("\n\nBuy from the ");
            if (comparablePricePerGallon > pricePerGallon)
                Write("American");
            else
                Write("Canadian");
            WriteLine(" station!");
            WriteLine("\tCanadian liter converted to price per gallon: {0:C}", comparablePricePerGallon);
        }
    }
}

/* MotorwayApp.cs
 * This application test the Motorway class
 * by instantiating objects of the class.
 */

using System;
using static System.Console;

namespace MotorwayApp
{
    public class MotorwayApp
    {
        static void Main(string[] args)
        {
            Motorway firstTest = new Motorway("Ramoth", "Drive", 'E', false, "State");
            firstTest.NumberOfLanes = 4;
            firstTest.Surface = "Blacktop";
            WriteLine("First Test\n" + firstTest);

            Motorway secondTest = new Motorway();
            secondTest.NameOfMotorway = "Fenelon";
            secondTest.TypeOfMotorway = "Street";
            secondTest.WhoMaintains = "County";
            secondTest.Direction = ' ';
            secondTest.Toll = true;
            secondTest.Surface = "Gravel";
            WriteLine("\n\nSecond Test\n" + secondTest);

            Motorway thirdTest = new Motorway("Oak", "Blvd", 'E', false, "County");
            WriteLine("\n\nThird Test\n");
            WriteLine("Motorway: " + thirdTest.NameOfMotorway + " " +
                                thirdTest.TypeOfMotorway + " " + thirdTest.Direction +
                                "\nToll: " + thirdTest.Toll +
                                "\nWho Maintains? " + thirdTest.WhoMaintains);

            ReadKey();
        }
    }
}

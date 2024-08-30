using System;

namespace Chapter04Question03
{
    internal class MotorwayApp
    {
        static void Main(string[] args)
        {
        string nameOfTheHighway = ReceiveNameOfTheHighway();
        string typeOfStreet = ReceiveTypeOfTheStreet();
        char direction = ReceiveDirection();
        string surface = ReceiveSurface();
        int numberOfLanes = ReceiveNumberOfLanes();
        bool toll = ReceiveToll();
        string maintainedBy = ReceiveMaintainedBy();

            Motorway motorway = new Motorway(nameOfTheHighway, typeOfStreet, direction, surface, numberOfLanes, toll, maintainedBy);
            Console.WriteLine(motorway.FullName());
            Console.WriteLine(motorway.FullNameAndToll());
            Console.WriteLine(motorway.FullNameAndNumberOfLanes());
            Console.WriteLine(motorway);

            Console.ReadKey();
        }
        static string ReceiveNameOfTheHighway()
        {
            Console.Write("Enter name of the highway : ");
            return Console.ReadLine();
        }
        static string ReceiveTypeOfTheStreet()
        {
            Console.Write("Enter type of the street (i.e., Road, Street, Avenue, Blvd., Lane, etc.) : ");
            return Console.ReadLine();
        }
        static char ReceiveDirection()
        {
            Console.Write("Enter direction (i.e., E, W, N, or S) : ");
            return char.Parse(Console.ReadLine());
        }
        static string ReceiveSurface()
        {
            Console.Write("Enter surface (i.e., blacktop, gravel, sand, and concrete) : ");
            return Console.ReadLine();
        }
        static int ReceiveNumberOfLanes()
        {
            Console.Write("Enter number of lanes : ");
            return int.Parse(Console.ReadLine());
        }
        static bool ReceiveToll()
        {
            Console.Write("Enter toll payment (true or false) : ");
            return bool.Parse(Console.ReadLine());
        }
        static string ReceiveMaintainedBy()
        {
            Console.Write("Enter party who maintain : ");
            return Console.ReadLine();
        }
    }
}

using System;
namespace TicketRecorder
{
    internal class TicketApp
    {
        static void Main(string[] args)
        {
            string studentNumber;
            char classif;
            int speedLimit;
            int speedTraveling;

            studentNumber = InputStudentNember();
            speedLimit = InputSpeed("speed limit");
            speedTraveling = InputSpeed("traveling speed");
            classif = InputClassif();

            Ticket ticket = new Ticket(studentNumber, classif, speedLimit, speedTraveling);
            Console.WriteLine(ticket);
            Console.ReadKey();
        }
        static string InputStudentNember()
        {
            Console.Write("Enter student number : ");
            string studentNumber = Console.ReadLine();
            return studentNumber;
        }
        static int InputSpeed(string speedValue)
        {
            Console.Write("Enter {0} : ", speedValue);
            int.TryParse(Console.ReadLine(), out int speedRecord);
            return speedRecord;
        }
        static char InputClassif()
        {
            Console.WriteLine("Enter classification:");
            Console.WriteLine("\tFreshmen (enter 1)");
            Console.WriteLine("\tSophomore (enter 2)");
            Console.WriteLine("\tJunior (enter 3)");
            Console.Write("\tSenior (enter 4) : ");
            char.TryParse(Console.ReadLine(), out char classifRecord);
            return classifRecord;
        }
    }
}
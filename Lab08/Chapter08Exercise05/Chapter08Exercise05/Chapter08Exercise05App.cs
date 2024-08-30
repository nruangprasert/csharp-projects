using System;

namespace Chapter08Exercise05
{
    internal class Chapter08Exercise05App
    {
        static void Main(string[] args)
        {
            string[] nameInput = new string[100];

            bool exit = false;
            int nameCount = 0;
            do
            {
                
                Console.WriteLine("\t\tEnter a name");
                Console.WriteLine("(First Name-followed by a space then the middle initial and Last Name)...");
                Console.WriteLine("\tTo Exit, press the Enter key");
                string inputExit = Console.ReadLine();
                if (inputExit == "") 
                { 
                    exit = true;
                }
                else
                {
                    nameInput[nameCount] = inputExit;
                    nameCount++;
                }

            }
            while (exit == false);

            string[] nameSplit = new string[nameCount];// now we know nameCount

            for (int i = 0; i < nameCount; i++)
            {
                string[] nameProcess = new string[2]; //temp array for switching
                   nameProcess = nameInput[i].Split(' '); //split to temp array
                nameSplit[i] = nameProcess[1]+", "+nameProcess[0]; //put temp array to final array
            }


            Array.Sort(nameSplit); //can be used with 1-dimensional array only

            Console.WriteLine();
            Console.WriteLine("Sorted Names");
            Console.WriteLine("------------");
                for(int i = 0; i < nameSplit.Length; i++) 
                {
                    Console.WriteLine(nameSplit[i]);    
                }
                Console.WriteLine();
            

            Console.ReadKey();
        }
    }
}
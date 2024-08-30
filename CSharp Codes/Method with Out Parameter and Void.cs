using System;

namespace ConsoleApp1
{
    class Method01
    {
        static void Main(string[] args)
        {
            // Use out parameters for multiple return values.
            
            GetTwoNumbers(out int value1, out int value2);
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            Console.ReadKey();  
        }
        static void GetTwoNumbers(out int number1, out int number2)
        {
            number1 = (int)Math.Pow(2, 2);
            number2 = (int)Math.Pow(3, 2);
        }

    }
}

using System;

class Program
{
    static void GetTwoNumbers(out int number1, out int number2)
    {
        number1 = (int)Math.Pow(2, 2);
        number2 = (int)Math.Pow(3, 2);
    }

    static KeyValuePair<int, int> GetTwoNumbers()
    {
        return new KeyValuePair<int, int>((int)Math.Pow(2, 2),
            (int)Math.Pow(3, 2));
    }

    static void Main()
    {
        // Use out parameters for multiple return values.
        int value1;
        int value2;
        GetTwoNumbers(out value1, out value2);
        Console.WriteLine(value1);
        Console.WriteLine(value2);

        // Use struct for multiple return values.
        var pair = GetTwoNumbers();
        Console.WriteLine(pair.Key);
        Console.WriteLine(pair.Value);
    }
}

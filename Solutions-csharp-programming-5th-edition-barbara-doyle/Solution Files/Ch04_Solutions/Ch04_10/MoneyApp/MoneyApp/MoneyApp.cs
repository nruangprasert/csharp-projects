/* MoneyApp.cs
 * This class tests the Money class
 * by instantiating several objects, using Money's
 * properties and calling 
 * methods that converts the cents into dollars
 * and dollars into cents.
 */

using System;
using static System.Console;

namespace MoneyApp
{
    class MoneyApp
    {
        static void Main(string[] args)
        {
            decimal amountToChange;
            Money firstMoney = new Money();
            firstMoney.Dollars = 5;
            firstMoney.Cents = 36;
            WriteLine("Original Amount --  " + firstMoney.Dollars + " Dollars " + firstMoney.Cents + " Cents");
            WriteLine();
            Write("Enter decrement amount -- ");

            amountToChange = AskForFullDollarAmount();

            Clear();
            WriteLine("\tDecrement Test");
            WriteLine("\nOriginal Amount: " + firstMoney.ToString());
            firstMoney.DecrementMoney(amountToChange);

            WriteLine("Amount to Subtract: " + amountToChange.ToString("F2") +
                                "\n\tNew Dollar Amount: " + firstMoney.Dollars.ToString("F2") +
                               "\n\tNew Cent Amount: " + "." + firstMoney.Cents +
                               "\n\tNew Full Amount: " + firstMoney.ToString());
            WriteLine("Press any key to see the next test......");
            ReadKey();

            Clear();
            Money nextMoneyTest = new Money(4, 2);
            WriteLine("\nSecond Test: ");
            WriteLine("\nNext Money Value: " + nextMoneyTest);
            WriteLine("Enter Increment amount (with decimal for cents).");
            amountToChange = AskForFullDollarAmount();

            Clear();
            WriteLine("\nSecond Test: ");
            WriteLine("Original Amount --  " + nextMoneyTest.Dollars + " Dollars " + nextMoneyTest.Cents + " Cents");
            nextMoneyTest.IncrementMoney(amountToChange);

            WriteLine();
            WriteLine("\tIncrement Test: ");
            WriteLine("\nAmount to Add: " + amountToChange.ToString("f2") +
                              "\n\tNew Amount: " + nextMoneyTest);
            WriteLine("Press any key to see the next test......");
            ReadKey();

            Clear();
            WriteLine("\n\nThird Test - input dollars and cents as separate values:");
            Money thirdTest = new Money(AskForInput("Dollars"), AskForInput("Cents as a whole number"));
            WriteLine("\nFull Dollar Amount: " + "\nAmount: " + thirdTest);

            WriteLine("Press any key to see the next test......");
            ReadKey();

            Clear();
            amountToChange = AskForFullDollarAmount();
            Money nextTest = new Money(amountToChange);
            WriteLine(nextTest.ReturnChange());

            WriteLine("Press any key to see the next test......");
            ReadKey();

            Clear();
            WriteLine("\n\nLast Test - Enter the monetary amount as a single value (with a decimal):");

            Money lastTest = new Money(AskForFullDollarAmount());
            WriteLine("Dollars: " + lastTest.Dollars.ToString("f2") +
                              "\nCents: " + "." + lastTest.Cents +
                              "\nAmount: " + lastTest.ToString());

          
            ReadKey();
        }

        static int AskForInput(string whichOne)
        {
            string inValue;
            Write("Enter {0}: ", whichOne);
            inValue = ReadLine();
            return (int.Parse(inValue));
        }

        static decimal AskForFullDollarAmount()
        {
            string inValue;
            Write("Enter the full dollar and cent amount: ");
            inValue = ReadLine();
            return (decimal.Parse(inValue));
        }
    }
}

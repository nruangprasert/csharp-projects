using System;

public class PurchaseApp
{
    public static void Main(string[] args)
    {
        int purchaseCount = 2;
        int purchaseNumber = 1;

        for (int i = 1; i <= purchaseCount; i++)
        {
            int invoiceNumber;
            double salesAmount;
            int numberOfItems;
            

            Console.WriteLine("Enter purchase details");
                Console.WriteLine("Enter invoice number: ");

            if (!int.TryParse(Console.ReadLine(), out invoiceNumber) || invoiceNumber < 1000 || invoiceNumber > 9000)
            {
                do
                {
                    Console.WriteLine("Invalid data entered for invoice");
                    Console.WriteLine("Enter a invoice number between 1000 and 9000 :");
                } while (!int.TryParse(Console.ReadLine(), out invoiceNumber) || invoiceNumber < 1000 || invoiceNumber > 9000);
            }

                Console.WriteLine("Enter the sales amount: ");
            if (!double.TryParse(Console.ReadLine(), out salesAmount) || salesAmount < 0)
            {
                do
                {
                    Console.WriteLine("Invalid data entered for sales amount, please enter a nonnegative value.");
                } while (!double.TryParse(Console.ReadLine(), out salesAmount) || salesAmount < 0);
            }

                Console.WriteLine("Enter number of items purchased : ");
                numberOfItems = int.Parse(Console.ReadLine());
            
                Purchase purchase = new Purchase(invoiceNumber, salesAmount, numberOfItems, purchaseNumber);

            Console.WriteLine(purchase.ToString());

            purchaseNumber += 1;
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

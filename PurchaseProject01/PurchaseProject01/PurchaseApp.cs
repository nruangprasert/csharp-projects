using System;

namespace PurchaseProject01
{
    internal class PurchaseApp
    {
        static void Main(string[] args)
        {
            int invoiceNumber = ReceiveInt("invoice number");
            double salesAmount = ReceiveSalesAmount();
            int numberOfItems = ReceiveInt("number of items");
            ProcessClass(invoiceNumber, salesAmount, numberOfItems);
            Console.ReadKey();
        }
        static int ReceiveInt(string intValue) 
        {
            Console.WriteLine("Enter {0} : ", intValue);
            int.TryParse(Console.ReadLine(), out int recordIntValue);
            return recordIntValue;
        }
        static double ReceiveSalesAmount()
        {
            Console.WriteLine("Enter the sales amount : ");
            double.TryParse(Console.ReadLine(), out double recordSalesAmount);
            return recordSalesAmount;
        }
        static void ProcessClass(int invoiceNumber, double salesAmount, int numberOfItems) 
        {
            Purchase purchase = new Purchase(invoiceNumber, salesAmount, numberOfItems);
            Console.WriteLine(purchase);
        }
    }
}
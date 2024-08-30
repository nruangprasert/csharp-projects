using System;

namespace PurchaseProject01
{
    internal class Purchase
    {
        const double SALES_TAX_RATE = 0.05;
        private int invoiceNumber;
        private double salesAmount;
        private double salesTaxAmount;
        private int numberOfItems;
        public Purchase()
        {
        }
        public Purchase(int invoiceNumber, double salesAmount, int numberOfItems) 
        {
            this.invoiceNumber = invoiceNumber; 
            this.salesAmount = salesAmount; 
            this.numberOfItems = numberOfItems;
        }
        public int InvoiceNumber
        { get { return invoiceNumber; } set { invoiceNumber = value; } }
        public double SalesAmount 
        { get { return salesAmount; } set { salesAmount = value; } }
        public double SalesTaxAmount 
        {  get { return salesTaxAmount; } set { salesTaxAmount = value; } }
        public int NumberofItems 
        { get { return numberOfItems; } set {  numberOfItems = value; } }
        public double CalculateSalesTax() 
        {
            return SALES_TAX_RATE * SalesAmount;
        }
        public double CalculateShippingCharges() 
        {
            if (numberOfItems < 3) 
            { return 3.50; }
            else if (numberOfItems >= 3 && numberOfItems <= 6) 
            { return 5.00; }
            else if (numberOfItems >= 7 && numberOfItems <= 10)
            { return 7.00; }
            else
            { return 10.00; }
        }
        public override string ToString()
        {
            return "\nInvoice number : " + invoiceNumber +
                    "\nSales amount : " + salesAmount +
                    "\nSales tax : " + SALES_TAX_RATE.ToString("P2") +
                    "\nSales tax amount : " + CalculateSalesTax().ToString("C2") +
                    "\nShipping charges : " + CalculateShippingCharges().ToString("C2") +
                    "\nTotal amount : " + (salesAmount + CalculateSalesTax() + CalculateShippingCharges()).ToString("C2");
        }
    }
}
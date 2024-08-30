using System;

public class Purchase
{
    private int invoiceNumber;
    private double salesAmount;
    private double salesTax;
    private double shippingCharges;
    private int numberOfItems;
    private int purchaseNumber; 
    public Purchase()
    {
        // Default values
        invoiceNumber = 0;
        salesAmount = 0.0;
        salesTax = 0.0;
        shippingCharges = 0.0;
        numberOfItems = 0;
        
    }

    public Purchase(int invoiceNumber, double salesAmount, int numberOfItems, int purchaseNumber)
    {
        this.invoiceNumber = invoiceNumber;
        this.salesAmount = salesAmount;
        this.numberOfItems = numberOfItems;
        this.purchaseNumber = purchaseNumber;

        CalculateSalesTax();
        CalculateShippingCharges();
        TotalAmount();
    }

    public int InvoiceNumber
    {
        get; set;
    }

    public double SalesAmount
    {
        get; set;
    }

    public double SalesTax
    {
        get;    
    }

    public double ShippingCharges
    {
        get;
    }

    public int NumberOfItems
    {
        get; set ;
    }
    public int PurchaseNumber
    {
        get; set;
    }

    public override string ToString()
    {
        return $"Purchase# {purchaseNumber} details\n" +
               $"Invoice number: {invoiceNumber}\n" +
               $"Sales amount: ${salesAmount:0.00}\n" +
               $"Sales tax: 5%\n" +
               $"Sales tax amount: ${salesTax:0.00}\n" +
               $"Shipping charges: ${shippingCharges:0.00}\n" +
               $"Total amount: ${TotalAmount():0.00}\n";
    }

    public double CalculateSalesTax()
    {
        return salesTax = salesAmount * 0.05;
    }

    public double CalculateShippingCharges()
    {
        if (numberOfItems < 3)
        {
            return shippingCharges = 3.50;
        }
        else if (numberOfItems < 7)
        {
            return shippingCharges = 5.00;
        }
        else if (numberOfItems < 11)
        {
            return shippingCharges = 7.00;
        }
        else
        {
            return shippingCharges = 10.00;
        }
    }
    public double TotalAmount()
    {
        return salesAmount + salesTax + shippingCharges;  
    }
}

/* Receipt.cs
 * This class includes data member that could be used by an automobile 
 * parts store. Items included as data members are customer name, address,
 * phone, receipt number, item number purchased, description, 
 * unit price and quantity purchased. 
 */

using System;

namespace ReceiptApp
{
    class Receipt
    {
        private string receiptNumber;
        private string dateOfPurchase;
        private string customerNumber;
        private string customerFirstName;
		private string customerLastName;
		private string customerAddress;
        private string customerPhone;
        private string itemNumber;
        private string itemDesc;
        private double unitPrice;
        private int qtyPurchased;

        public Receipt()
        {
        }

        public Receipt (string rNum)
        {
            receiptNumber = rNum;
        }

        public Receipt(string rNum, string cNum)
        {
            receiptNumber = rNum;
            customerNumber = cNum;
        }

        public Receipt(string rNum, string cNum, string cFName, string cLName, 
					   string cAddress, string cPhone)
        {
            receiptNumber = rNum;
            customerNumber = cNum;
			customerLastName = cLName;
            customerFirstName = cFName;
            customerAddress = cAddress;
            customerPhone = cPhone;
        }
        
        public Receipt (string rNum, string iNum, string iDesc, double uPrice, int qty)
        {
            receiptNumber = rNum;
            itemNumber = iNum;
            itemDesc = iDesc;
            unitPrice = uPrice;
            qtyPurchased = qty;
        }

		public Receipt(string rNum, string cNum, string iNum, string iDesc, 
					   double uPrice, int qty)
        {
            receiptNumber = rNum;
            customerNumber = cNum;
            itemNumber = iNum;
            itemDesc = iDesc;
            unitPrice = uPrice;
            qtyPurchased = qty;
        }

        public Receipt(string rNum, string purchaseDate, string cNum, string cFName, string cLName,
					   string cAddress, string cPhone, string iNum, string iDesc, double uPrice, int qty)
        {
            receiptNumber = rNum;
            dateOfPurchase = purchaseDate;
            customerNumber = cNum;
            customerFirstName = cFName;
			customerLastName = cLName;
            customerAddress = cAddress;
            customerPhone = cPhone;
            itemNumber = iNum;
            itemDesc = iDesc;
            unitPrice = uPrice;
            qtyPurchased = qty;
        }

        public string ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                receiptNumber = value;
            }
        }

        public string DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                dateOfPurchase = value;
            }
        }

        public string CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                customerNumber = value;
            }
        }

        public string CustomerFirstName
        {
            get
            {
                return customerFirstName;
            }
            set
            {
                customerFirstName = value;
            }
        }

		public string CustomerLastName
		{
			get
			{
				return customerLastName;
			}
			set
			{
				customerLastName = value;
			}
		}
		public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }

        public string CustomerPhone
        {
            get
            {
                return customerPhone;
            }
            set
            {
                customerPhone = value;
            }
        }

 
        public string ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                itemNumber = value;
            }
        }

        public string ItemDesc
        {
            get
            {
                return itemDesc;
            }
            set
            {
                itemDesc = value;
            }

        }

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }

        public int QtyPurchased
        {
            get
            {
                return qtyPurchased;
            }
            set
            {
                qtyPurchased = value;
            }
        }

        public double CalculateTotalCost()
        {
            return unitPrice * qtyPurchased;
        }

        public override string ToString()
        {
            return "Customer: " + customerFirstName + " " + customerLastName +
				   "\nPhone: " + customerPhone +
                   "\nTotal Purchases: " + CalculateTotalCost().ToString("C");

        }
    }
}

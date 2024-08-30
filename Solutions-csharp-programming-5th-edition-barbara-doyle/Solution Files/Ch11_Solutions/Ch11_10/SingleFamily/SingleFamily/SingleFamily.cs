using System;
using HousingNamespace;


namespace SingleFamilyNamespace
{
    public class SingleFamily : Housing
    {
		private string subDivName;
        private int numberOfBedrooms;
        private int numberOfBathrooms;
		private bool garage;
		private bool porch;
		private string style;
        private decimal rentAmount;
		
		public SingleFamily()
		{
		}

		public SingleFamily(int yr, string addr, string type,  
					string cCrew, bool fireH, string name,
				bool grg, bool pch, string stl, decimal rentAmt, string info, string subName)
			: base(yr, addr, type,  cCrew, fireH)
		{
			subDivName = name;
			garage = grg;
			porch = pch;
			style = stl;
            subDivName = subName;	
            rentAmount = rentAmt;
		}

        public SingleFamily(string addr, int beds, int baths, decimal rent)
            : base(addr)
        {
            numberOfBedrooms = beds;
            numberOfBathrooms = baths;
            rentAmount = rent;
        }

		public int NumberOfBedrooms
		{
			get
			{
			   return numberOfBedrooms;
			}
			set
			{
				numberOfBedrooms = value;
			}
		}

        public int NumberOfBathrooms
        {
            get
            {
                return numberOfBathrooms;
            }
            set
            {
                numberOfBathrooms = value;
            }
        }
		public string SubDivName
		{
			get
			{
				return subDivName;
			}
			set
			{
				subDivName = value;
			}
		}
		
		public bool Garage
		{
			get
			{
				return garage;
			}
			set
			{
				garage = value;
			}
		}		

		public bool Porch
		{
			get
			{
				return porch;
			}
			set
			{
				porch = value;
			}
		}		
		
        public decimal RentAmount
        {
            get
            {
                return rentAmount;
            }
            set
            {
                rentAmount = value;
            }
        }

        public override decimal ProjectedRentalAmt()
        {
            return 12M * rentAmount;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nNumber of Bedrooms: " + numberOfBedrooms +
                "\nNumber of Bathrooms: " + numberOfBathrooms +
                "\nMonthlty Rental Rate:" + rentAmount.ToString("C") +
                "\n\nExpected Annual Rents: " + ProjectedRentalAmt().ToString("C");

        }
	}
}



/* Housing.cs   
 * This class is the base class 
 * for a housing application. It includes
 * charaacters common to all types of
 * housing.
 */
using System;

namespace HousingNamespace
{
    public class Housing
    {
        private int yearBuilt;
		private string address;
		private string typeOfConstruction;		
		private string cleaningCrewNameNum;
		private bool insuranceClaimHistory;	
		
		public Housing()
		{
  		}

		public Housing(int yr, string addr, string contructionType, 
            string cCrew, bool fireH)
		{
			yearBuilt = yr;
			address = addr;
			typeOfConstruction = contructionType;			
			cleaningCrewNameNum = cCrew;
			insuranceClaimHistory = fireH;
		}

        public Housing(int yr, string addr)
        {
            yearBuilt = yr;
			address = addr;
        }

        public Housing(string addr)
        {
            address = addr;
        }

        public Housing(string addr, string cleaningCrewInfo)
        {
			address = addr;
            cleaningCrewNameNum = cleaningCrewInfo;
        }


		public int YearBuilt
		{
			get
			{
				return yearBuilt;
			}
			set
			{
				yearBuilt = value;
			}
		}
		
		public string Address
		{
			get
			{
				return address;
			}
			set
			{
				address = value;
			}
		}

		public string TypeOfConstruction
		{
			get
			{
				return typeOfConstruction;
			}
			set
			{
				typeOfConstruction = value;
			}
		}

		public string CleaningCrewNameNum
		{
			get
			{
				return cleaningCrewNameNum;
			}
			set
			{
				cleaningCrewNameNum = value;
			}
		}

		public bool InsuranceClaimHistory
		{
			get
			{
				return insuranceClaimHistory;
			}
			set
			{
				insuranceClaimHistory = value;
			}
		}

        public virtual decimal ProjectedRentalAmt()
		{
			return 0M;
		}
		
		public override string ToString( )
		{
		    return "\nAddress: " + address;
			}
		}
	}


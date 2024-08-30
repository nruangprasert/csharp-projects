using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollApp
{
    internal class Employee
    {
        private string fName;
        private string lName;
        private int numOfDep;
        private int numOfHours;

        public Employee()
        {

        }

        public Employee(string fn, string ln, int nDep, int nHours)
        {
            fName = fn;
            lName = ln;
            numOfDep = nDep;
            numOfHours = nHours;
        }

        public string FName 
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public int NumofDep
        {
            get { return numOfDep; }
            set { numOfDep = value; }
        }
        public int NumOfHours
        {
            get { return numOfHours; } 
            set { numOfHours = value; }
        }

        public double DetermineGross()
        {
            const double HOURLY_RATE = 80.00;
            return numOfHours * HOURLY_RATE;

        }
        public double DetermineAgencyFee()
        {
            const double AGENCY_CHARGE = 0.13;
            return DetermineGross() * AGENCY_CHARGE;
        }
        public double DetermineSocSec() 
        {
            const double SOCIAL_SEC_DED = 0.0785;
            return DetermineGross() * SOCIAL_SEC_DED;
        }

        public double DetermineFedTax() 
        {
            const double FED_TAX = 0.25;
            const double DEP_ALLOWANCE = 0.0575;
            double gross = DetermineGross();
            return (gross - (gross * (DEP_ALLOWANCE * numOfDep))) * FED_TAX;
        }
        public double DetermineNet()
        {
            return DetermineGross() - DetermineAgencyFee() - DetermineSocSec()
                -DetermineFedTax();
        }
        public override string ToString()
        {
            string str = fName + " " + lName + " take home pay " +
                DetermineNet().ToString("C2");
            return str;
        }




    }

}

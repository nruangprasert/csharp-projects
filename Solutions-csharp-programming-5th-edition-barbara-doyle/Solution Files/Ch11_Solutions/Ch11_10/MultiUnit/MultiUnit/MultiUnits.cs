using System;
using HousingNamespace;
using IUnitsNamespace;


namespace MultiUnitNamespace
{
    public class MultiUnits : Housing, IUnits
    {
        private string complexName;
        private int numberOfUnits;
        private decimal rentAmountPerUnit;

        public MultiUnits()
        {
        }


        public MultiUnits(int yrBuilt, string addr, string typeOfConstr,
                        string cleaningCrew, bool insRecords, int numberUnits,
                    string name, decimal rentAmt, string info)
            : base(yrBuilt, addr, typeOfConstr, cleaningCrew, insRecords)
        {
            numberOfUnits = numberUnits;
            complexName = name;
            rentAmountPerUnit = rentAmt;
        }

        public MultiUnits(string addr, int numberUnits, decimal rentAmt)
            : base(addr)
        {
            numberOfUnits = numberUnits;
            rentAmountPerUnit = rentAmt;
        }

        public MultiUnits(string addr, string complex, int numberUnits, decimal rentAmt)
            : base(addr)
        {
            complexName = complex;
            numberOfUnits = numberUnits;
            rentAmountPerUnit = rentAmt;
        }


        public int NoOfUnits
        {
            get
            {
                return numberOfUnits;
            }
            set
            {
                numberOfUnits = value;
            }
        }

        public string ComplexName
        {
            get
            {
                return complexName;
            }
            set
            {
                complexName = value;
            }
        }

        public decimal RentAmountPerUnit
        {
            get
            {
                return rentAmountPerUnit;
            }
            set
            {
                rentAmountPerUnit = value;
            }
        }

        public override decimal ProjectedRentalAmt()
        {
            return 12 * rentAmountPerUnit * numberOfUnits;
        }

        public int GetNumUnits()  // Interface's method
        {
            return numberOfUnits;
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nNumber of Units: " + GetNumUnits() +
                "\nPer Unit Rent: " + rentAmountPerUnit.ToString("C") +
                "\n\nProjected Annual Rent From This Address: " + ProjectedRentalAmt().ToString("C");
        }
    }
}
    
using System;

namespace Chapter04Question07
{
    internal class Park
    {
        private string nameOfPark;
        private string location;
        private string typeOfPark;
        private string facility;
        private double fee;
        private int numberOfEmployees;
        private int numberOfVisitors;
        private double annualBudget;
        public Park() { }
        public Park (string nameOfPark, string location, string typeofPark, string facility) 
        {
            this.nameOfPark = nameOfPark;
            this.location = location;
            this.typeOfPark = typeofPark;
            this.facility = facility;
        }
        public Park(string nameOfPark, string location, string typeOfPark, string facility, double fee, int numberOfEmployees, int numberOfVisitors, double annualBudget) : this(nameOfPark, location, typeOfPark, facility)
        {
            this.fee = fee;
            this.numberOfEmployees = numberOfEmployees;
            this.numberOfVisitors = numberOfVisitors;
            this.annualBudget = annualBudget;
        }
        public string NameOfPark { get { return nameOfPark; } set { nameOfPark = value; } }
        public string Location { get { return location; } set { location = value; } }
        public string TypeOfPark { get { return typeOfPark; } set {  typeOfPark = value; } }
        public string Facility { get { return facility; } set { facility = value; } }
        public double Fee { get { return fee; } set { fee = value; } }
        public int NumberOfEmployees { get { return numberOfEmployees; } set { numberOfEmployees = value; } }
        public int NumberOfVisitors { get {  return numberOfVisitors; } set { numberOfVisitors = value; } }
        public double AnnualBudget { get { return annualBudget; } set { annualBudget = value; } }

        public string Return01 ()
        {
          return "\n###Return 01###" + 
                "\nName of the park is : " + nameOfPark + 
                 "\nLocation is : " + location +
                 "\nType of Park is : " + typeOfPark;
        }
        public string Return02()
        {
            return "\n###Return 02###" +
                "\nName of the park is : " + nameOfPark +
                   "\nLocation is : " + location +
                   "\nFacility of Park is : " + facility;
        }
        public string Return03()
        {
            return "\n###Return 03###" +
                "\nCost per visitor is : " + $"{annualBudget / numberOfVisitors:C2}";
        }
        public string Return04()
        {
            return "\n###Return 04###" +
                "\nRevenue from fee is : " + $"{numberOfVisitors*fee:C2}";
        }
        public override string ToString()
        {
            return "\n###All Data Members###" +
                "\nName of the park is : " + nameOfPark +
                 "\nLocation is : " + location +
                 "\nType of Park is " + typeOfPark +
                 "\nFacility of Park is : " + facility +
                 "\nFee is : " + fee.ToString("C2") +
                 "\nNumber of employees is : " + numberOfEmployees +
                 "\nNumber of visitors is : " + numberOfVisitors +
                 "\nAnnual budget is : " + annualBudget.ToString("C2");
        }

    }
}

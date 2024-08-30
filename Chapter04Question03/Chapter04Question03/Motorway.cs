using System;

namespace Chapter04Question03
{
    internal class Motorway
    {
        private string nameOfTheHighway;
        private string typeOfStreet;
        private char direction;
        private string surface;
        private int numberOfLanes;
        private bool toll;
        private string maintainedBy;
        public Motorway ()
        {

        }
        public Motorway(string nameOfTheHighway, string typeOfStreet, char direction, string surface, int numberOfLanes, bool toll, string maintainedBy)
        {
            this.nameOfTheHighway = nameOfTheHighway;
            this.typeOfStreet = typeOfStreet;
            this.direction = direction;
            this.surface = surface;
            this.numberOfLanes = numberOfLanes;
            this.toll = toll;
            this.maintainedBy = maintainedBy;
        }
        public string NameOfTheHighway { get; set;}
        public string TypeOfStreet { get; set;}
        public char Direction { get; set;}
        public string Surface { get; set;}
        public int NumberOfLanes { get; set;}
        public bool Toll { get; set;}
        public string MaintainedBy { get; set;}
        public string FullName()
        {
            return "\nFull name = " + nameOfTheHighway + " " + typeOfStreet + " " + direction; 
        }
        public string FullNameAndToll()
        {
            return "\n" + FullName() + "\nToll = " + toll;
        }
        public string FullNameAndNumberOfLanes()
        {
            return "\n" + FullName() + "\nNumber of lanes = " + numberOfLanes;
        }
        public override string ToString()
        {
            return "\nName of the highway : " + nameOfTheHighway +
                    "\nType of the street : " + typeOfStreet +
                    "\nDirection : " + direction +
                    "\nSurface : " + surface +
                    "\nNumber of Lanes : " + numberOfLanes +
                    "\ntoll : " + toll +
                    "\nMaintained by : " + maintainedBy;
        }
    }
}

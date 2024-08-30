using System;

namespace Chapter04Question01
{
    internal class Date
    {
        private int year;
        private int month;
        private int day;
        private string nameOfTheMonth;
        public Date()
        {
        }
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;

            switch (month)
            {
                case 1:
                    this.nameOfTheMonth = "January";
                    break;
                case 2:
                    this.nameOfTheMonth = "February";
                    break;
                case 3:
                    this.nameOfTheMonth = "March";
                    break;
                case 4:
                    this.nameOfTheMonth = "April";
                    break;
                case 5:
                    this.nameOfTheMonth = "May";
                    break;
                case 6:
                    this.nameOfTheMonth = "June";
                    break;
                case 7:
                    this.nameOfTheMonth = "July";
                    break;
                case 8:
                    this.nameOfTheMonth = "August";
                    break;
                case 9:
                    this.nameOfTheMonth = "September";
                    break;
                case 10:
                    this.nameOfTheMonth = "October";
                    break;
                case 11:
                    this.nameOfTheMonth = "November";
                    break;
                case 12:
                    this.nameOfTheMonth = "December";
                    break;
            }
        }
        public int Year {get; set;}
        public int Month { get; set; }
        public int Day { get; set; }
        public string NameOfTheMonth { get; set; }

        public override string ToString()
        {
            return "\nDate = " + nameOfTheMonth + "/" + day + "/" + year; 
        }
    }
    
}

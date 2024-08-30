/* This class includes members for creating a mailing label customer code.
 * Data members include full name (first name entered first), 
 * birthdate (mm/dd/yyyy), month (number) they purchased a 
 * subscription,  and zip code. 
 * The generated mailing label contains last name, followed by 
 * birth year, the number of characters in the full name,
 * the first three characters of the month name they purchased 
 * the subscription and the last two digits of their zip code. 
*/
using System;

namespace CustomerCodeApp
{
    class CustomerCode
    {
        private string fullName;
        private string birthDate;
        private string zipCode;
        private int subscriptionMonth;

        public CustomerCode()
        {
        }
        public CustomerCode(string name, string bDate, string zp, int sMonth)
        {
            fullName = name;
            birthDate = bDate;
            zipCode = zp;
            subscriptionMonth = sMonth;
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public string Birthdate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }
        public int SubscriptionMonth
        {
            get
            {
                return subscriptionMonth;
            }
            set
            {
                subscriptionMonth = value;
            }
        }

        public string GetlastName()
        {
            string[] nameArray;
            nameArray = fullName.Split(' ');
            return nameArray[1];
        }

        public string GetSubscriptionMonth()
        {
            string monName;
            switch (subscriptionMonth)
            {
                case 1: monName = "Jan";
                    break;
                case 2: monName = "Feb";
                    break;
                case 3: monName = "Mar";
                    break;
                case 4: monName = "Apr";
                    break;
                case 5: monName = "May";
                    break;
                case 6: monName = "Jun";
                    break;
                case 7: monName = "Jul";
                    break;
                case 8: monName = "Aug";
                    break;
                case 9: monName = "Sep";
                    break;
                case 10: monName = "Oct";
                    break;
                case 11: monName = "Nov";
                    break;
                case 12: monName = "Dec";
                    break;
                default: monName = "unk";
                    break;
            }
            return monName;
        }

        public string GetBirthYear()
        {
            string[] birthDateArray;
            birthDateArray = birthDate.Split('/');
            return birthDateArray[2].Substring(2);
        }

        public string GetSmallZip()
        {
            return zipCode.Substring(3);
        }

        public override string ToString()
        {
            return GetlastName() + GetBirthYear() + 
                fullName.Length + GetSubscriptionMonth() + GetSmallZip();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRegisterApp
{
    class Customer
    {
        private string lastName;
        private string firstName;
        private long accountNumber;
        private decimal acctBalance;


        //Default constructor
        public Customer()
        {
        }

        public Customer(string last, string first,
                        long account, decimal bal)
        {
            lastName = last;
            firstName = first;
            accountNumber = account;
            acctBalance = bal;
        }

        public Customer(string last, string first,
                long account)
        {
            lastName = last;
            firstName = first;
            accountNumber = account;
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public long AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }

        public decimal AccountBalance
        {
            set
            {
                acctBalance = value;
            }
            get
            {
                return acctBalance;
            }
        }

        public void WithdrawFunds(decimal withdrawal)
        {
            acctBalance -= withdrawal;
        }

        public void DepositFunds(decimal deposit)
        {
            acctBalance += deposit;
        }

        public override string ToString()
        {
            return "Name: " + firstName + " " + lastName +
                   "\nAccount Number: " + accountNumber +
                   "\nAccount Balance: " + acctBalance;
        }
    }
}

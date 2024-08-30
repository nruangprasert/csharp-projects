/*BankAccount.cs
 * Bank Account class that keeps a users name and balance.
 * Will throw an exception if the balance becomes negative
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class BankAccount
    {
        private decimal balance;
        private String owner;

        public BankAccount()
        {

        }
        public BankAccount(String person)
        {
            owner = person;
            balance = 0;
        }

        public BankAccount(String person, decimal amount)
        {
            owner = person;
            if (amount < 0)
            {
                throw new NegativeException("Error: Negative Balance");
            }
            else
                balance = amount;
        }

        public decimal Balance
        {
            get
            {
                return (balance);
            }

            set
            {
                decimal temp = value;


                if (temp < 0)
                {
                    throw new NegativeException("Error: Negative Balance");
                }
                else
                    balance = temp;

            }

        }

        public void IncreaseBalance(decimal amt)
        {
            if (amt < 0)
                throw new NegativeException("Error: Negative Increase");
            else
                balance += amt;
        }

        public void DecreaseBalance(decimal amt)
        {
            if (amt < 0)
                throw new NegativeException("Error: Negative Increase");
            else
                balance -= amt;
            if (balance < 0)
                throw new NegativeException("Error: Negative Increase");
        }

        public String Owner
        {
            get
            {
                return (owner);
            }
            set
            {
                owner = value;
            }
        }
        public override string ToString()
        {
            return owner + " has a balance of " + balance;
        }
    }
}

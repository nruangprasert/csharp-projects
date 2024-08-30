/* NegativeException.cs
 * An exception class for the BankAccount class
 */
using System;
using System.Threading.Tasks;

namespace BankApp
{
    class NegativeException : System.ApplicationException
    {
        public NegativeException()
            : base()
        {
        }

        public NegativeException(string message)
            : base(message)
        {

        }

        public NegativeException(string message, Exception inner)
            : base(message, inner)
        {

        }


    }
}

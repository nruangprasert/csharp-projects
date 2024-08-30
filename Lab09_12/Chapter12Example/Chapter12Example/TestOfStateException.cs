using System;
namespace Chapter12Example
{
    internal class TestOfStateException : ApplicationException
    {
        public TestOfStateException(string exceptionType) : base(exceptionType)
        {
        }
    }
}
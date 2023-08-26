namespace _6.ExceptionHandling
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }
}

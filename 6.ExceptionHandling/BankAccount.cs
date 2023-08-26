namespace _6.ExceptionHandling
{
    class BankAccount
    {
        private double balance;

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient funds.");
            }
            balance -= amount;
            Console.WriteLine("Withdrawal successful.");
        }
    }
}

namespace _5.Object_OrientedProgrammingBasics
{
    class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}

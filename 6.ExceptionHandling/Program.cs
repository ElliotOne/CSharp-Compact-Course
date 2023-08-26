namespace _6.ExceptionHandling
{
    internal class Program
    {
        static void Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            int result = dividend / divisor;
            Console.WriteLine("Result: " + result);
        }

        static void Main(string[] args)
        {
            //1.Try-Catch Block
            try
            {
                int dividend = 10;
                int divisor = 0;
                int result = dividend / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            //2.Multiple Catch Blocks
            try
            {
                int[] numbers = { 1, 2, 3 };
                int index = 5;
                int value = numbers[index];
                Console.WriteLine("Value: " + value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            //3.Throwing Exceptions
            try
            {
                Divide(10, 0);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            //4.Finally Block
            try
            {
                int[] numbers = { 1, 2, 3 };
                int index = 5;
                int value = numbers[index];
                Console.WriteLine("Value: " + value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }



            //5.Custom Exceptions
            try
            {
                BankAccount account = new BankAccount();
                account.Withdraw(500);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            Console.ReadKey();
        }
    }
}
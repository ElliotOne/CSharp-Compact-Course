namespace _9.BasicDebuggingTechniques
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            int sum = x + y; // Set a breakpoint here

            Console.WriteLine("Sum: " + sum);



            int[] numbers = { 10, 20, 30, 40, 50 };
            int total = 0;

            foreach (int num in numbers)
            {
                total += num; // Step through this line in the loop
            }

            Console.WriteLine("Total: " + total);



            int a = 5;
            int b = 10;
            int result = Add(a, b);

            Console.WriteLine("Result: " + result);



            int[] numbers2 = { 15, 30, 45, 60, 75 };
            int total2 = 0;

            foreach (int num in numbers2)
            {
                total2 += num;

                if (total2 > 100) // Set a conditional breakpoint here
                {
                    Console.WriteLine("Total exceeded 100.");
                }
            }

            Console.WriteLine("Final Total: " + total2);



            int[] numbers3 = { 5, 10, 15, 20, 25 };
            int sum2 = 0;

            foreach (int num in numbers3)
            {
                sum2 += num; // Watch the 'sum' variable in this loop
                Console.WriteLine("Current sum: " + sum2);
            }

            Console.WriteLine("Final sum: " + sum2);



            try
            {
                int dividend = 10;
                int divisor = 0;
                int result2 = dividend / divisor;
                Console.WriteLine("Result: " + result2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        static int Add(int x, int y)
        {
            int sum = x + y; // Inspect the 'sum' variable here
            return sum;
        }
    }
}
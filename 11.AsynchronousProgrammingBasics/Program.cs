namespace _11.AsynchronousProgrammingBasics
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Before async method.");

            await DoSomethingAsync();

            Console.WriteLine("After async method.");



            Console.WriteLine("Before async method.");

            Task<string> task = GetResultAsync();
            Console.WriteLine("Async method started.");

            string result = await task;

            Console.WriteLine("Async method completed. Result: " + result);



            Task<int> task1 = DoAsyncWork(1);
            Task<int> task2 = DoAsyncWork(2);

            int result1 = await task1;
            int result2 = await task2;

            Console.WriteLine("Result from task1: " + result1);
            Console.WriteLine("Result from task2: " + result2);



            try
            {
                await DoAsyncWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            Task<int> task3 = DoAsyncWork(1);
            Task<int> task4 = DoAsyncWork(2);

            await Task.WhenAll(task3, task4);

            Console.WriteLine("Result from task1: " + task3.Result);
            Console.WriteLine("Result from task2: " + task4.Result);



            Console.ReadKey();
        }


        //1.Basic Asynchronous Method
        static async Task DoSomethingAsync()
        {
            await Task.Delay(2000); // Simulating async work
            Console.WriteLine("Async method completed.");
        }



        //2.Returning Task from Asynchronous Method
        static async Task<string> GetResultAsync()
        {
            await Task.Delay(2000); // Simulating async work
            return "Async result";
        }



        //3.Multiple Asynchronous Methods
        static async Task<int> DoAsyncWork(int id)
        {
            await Task.Delay(1000 * id); // Simulating async work
            return id * 10;
        }



        //4.Handling Exceptions in Asynchronous Methods
        static async Task DoAsyncWork()
        {
            await Task.Delay(2000);
            throw new InvalidOperationException("Something went wrong.");
        }



        //5.Using Task.WhenAll for Parallelism
        static async Task<int> DoAsyncWork2(int id)
        {
            await Task.Delay(1000 * id); // Simulating async work
            return id * 10;
        }
    }
}
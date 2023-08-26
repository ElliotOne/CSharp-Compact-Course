namespace _4.FunctionsAndMethods
{
    internal class Program
    {
        //1.Function definition
        static void PrintMessage()
        {
            Console.WriteLine("Hello from PrintMessage!");
        }

        //3.Function with parameters and return value
        static int Add(int a, int b)
        {
            return a + b;
        }

        //4.Function Overloading
        static void Print(string message)
        {
            Console.WriteLine(message);
        }

        static void Print(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        //5.Passing Parameters by Reference
        //Function that modifies its parameter
        static void ModifyValue(ref int value)
        {
            value *= 2;
        }

        static void SalaryCalculate(ref int salary)
        {
            int bonus = 3000;
            salary = bonus + salary;
        }
        static void Tax(out int tax)
        {
            tax = 500;
        }

        //6.Default Parameter Values
        static void Greet(string name = "Guest")
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        //7.Params Keyword
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        static void Main(string[] args)
        {
            //2.Calling the function
            PrintMessage();


            int result = Add(5, 3);
            Console.WriteLine("Result: " + result);


            Print("Hello!");
            Print(42);


            int number = 5;
            ModifyValue(ref number);
            Console.WriteLine("Modified number: " + number);

            int salary = 40000;
            SalaryCalculate(ref salary);
            Console.WriteLine("Salary with Bonus: " + salary);

            int tax;
            Tax(out tax);
            Console.WriteLine("Salary Excluded Tax: " + (salary - tax));


            Greet();         // Output: Hello, Guest!
            Greet("Alice"); // Output: Hello, Alice!


            int sumResult = Sum(1, 2, 3, 4, 5);
            Console.WriteLine("Sum: " + sumResult);



            Console.ReadKey();
        }
    }
}
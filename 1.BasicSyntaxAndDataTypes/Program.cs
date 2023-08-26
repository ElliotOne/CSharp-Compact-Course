namespace _1.BasicSyntaxAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //1.Variables and Data Types
            int age = 25;           // Integer variable
            double salary = 50000.5; // Double-precision floating-point variable
            string name = "John";    // String variable
            char grade = 'A';        // Character variable
            bool isActive = true;    // Boolean variable



            //2.Variable Initialization and Assignment
            int x;          // Variable declaration
            x = 10;         // Variable assignment

            double pi = 3.14;   // Variable declaration and assignment
            pi = 3.14159;       // Variable reassignment

            string message = "Hello, ";   // String concatenation
            message += "world!";          // Appending to the string



            //3.Operators and Expressions
            int a = 10, b = 5;
            int sum = a + b;      // Addition
            int difference = a - b; // Subtraction
            int product = a * b;  // Multiplication
            int quotient = a / b; // Division
            int remainder = a % b; // Modulus (remainder)



            //4.Type Conversion (Casting)
            int intValue = 50;
            double doubleValue = intValue; // Implicit conversion

            double doubleValue2 = 123.45;
            int intValue2 = (int)doubleValue2; // Explicit casting



            //5.String Interpolation
            string firstName = "Alice";
            int age2 = 30;
            string greeting = $"Hello, {firstName}! You are {age2} years old.";



            //6.Constants
            const double pi_val = 3.14159; // Constant declaration
            //double circleArea = pi * radius * radius;
            double circleArea = pi_val * 10 * 10;



            Console.ReadKey(); //To keep console running
        }
    }
}
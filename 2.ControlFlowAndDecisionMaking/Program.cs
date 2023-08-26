namespace _2.ControlFlowAndDecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.If Statement
            int age = 18;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }



            //2.If-Else Statement
            int score = 85;
            if (score >= 60)
            {
                Console.WriteLine("You passed.");
            }
            else
            {
                Console.WriteLine("You failed.");
            }



            //3.Else-If Statement
            int num = 0;
            if (num > 0)
            {
                Console.WriteLine("Number is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else
            {
                Console.WriteLine("Number is zero.");
            }



            //4.Switch Statement
            int dayOfWeek = 3;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }



            //5.While Loop
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("Count: " + count);
                count++;
            }



            //6.Do-While Loop
            int num2 = 1;
            do
            {
                Console.WriteLine("Number: " + num2);
                num2++;
            } while (num2 <= 5);



            //7.For Loop
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }



            //8.Break and Continue Statements
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break; // Exit the loop
                }
                if (i % 2 == 0)
                {
                    continue; // Skip even numbers
                }
                Console.WriteLine("Number: " + i);
            }



            //9.Nested Loops
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("i: " + i + ", j: " + j);
                }
            }



            Console.ReadKey();
        }
    }
}
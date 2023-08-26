namespace _3.ArraysAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Arrays
            // Declaration and initialization
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Array initialization shorthand
            int[] moreNumbers = { 5, 15, 25, 35, 45 };

            // Accessing elements
            int secondNumber = numbers[1];

            // Looping through an array
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }



            //2.Lists
            // List declaration and initialization
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Carol");

            // List initialization shorthand
            List<int> scores = new List<int> { 85, 92, 78, 95, 88 };

            // Accessing elements
            string firstPerson = names[0];

            // Looping through a list
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }



            //3.Dictionaries
            // Dictionary declaration and initialization
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages["Alice"] = 30;
            ages["Bob"] = 25;
            ages["Carol"] = 28;

            // Dictionary initialization shorthand
            Dictionary<string, string> countries = new Dictionary<string, string>
            {
                { "USA", "United States" },
                { "CAN", "Canada" },
                { "GBR", "United Kingdom" }
            };

            // Accessing values using keys
            int aliceAge = ages["Alice"];

            // Looping through a dictionary
            foreach (KeyValuePair<string, int> entry in ages)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }



            //4.Collections with LINQ
            // Filtering elements using LINQ
            List<int> evenNumbers = numbers.Where(num => num % 2 == 0).ToList();

            // Transforming elements using LINQ
            List<string> upperCaseNames = names.Select(name => name.ToUpper()).ToList();

            // Summing elements using LINQ
            int sumOfScores = scores.Sum();

            // Finding elements using LINQ
            int maxScore = scores.Max();



            Console.ReadKey();
        }
    }
}
namespace _5.Object_OrientedProgrammingBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2022;

            Console.WriteLine("Car details:");
            Console.WriteLine("Make: " + myCar.Make);
            Console.WriteLine("Model: " + myCar.Model);
            Console.WriteLine("Year: " + myCar.Year);

            myCar.Start();
            myCar.Stop();



            Person person1 = new Person("Alice");
            Person person2 = new Person("Bob");



            //Inheritance
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Bark();



            //Polymorphism
            Shape shape = new Circle();
            shape.Draw(); // Output: Drawing a circle.



            //Encapsulation
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            double balance = account.GetBalance();
            Console.WriteLine("Balance: " + balance);



            Console.ReadKey();
        }
    }



    //Defining a Class
    class Car
    {
        public string Make;
        public string Model;
        public int Year;

        public void Start()
        {
            Console.WriteLine("Car started.");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped.");
        }
    }



    //Constructors and Destructors
    class Person
    {
        public string Name;

        // Constructor
        public Person(string name)
        {
            Name = name;
            Console.WriteLine("Person created: " + Name);
        }

        // Destructor
        ~Person()
        {
            Console.WriteLine("Person destroyed: " + Name);
        }
    }
}
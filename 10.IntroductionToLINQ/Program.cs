namespace _10.IntroductionToLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Querying a Collection
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query to filter even numbers
            var evenNumbers = from num in numbers
                              where num % 2 == 0
                              select num;

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }



            //2.Selecting and Transforming Data
            List<string> names = new List<string> { "Alice", "Bob", "Carol", "David" };

            // LINQ query to select names longer than 4 characters
            var longNames = from name in names
                            where name.Length > 4
                            select name.ToUpper();

            foreach (var name in longNames)
            {
                Console.WriteLine(name);
            }



            //3.Ordering Data
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Grapes" };

            // LINQ query to order fruits alphabetically
            var sortedFruits = from fruit in fruits
                               orderby fruit
                               select fruit;

            foreach (var fruit in sortedFruits)
            {
                Console.WriteLine(fruit);
            }



            //4.Grouping Data
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ query to group numbers by even and odd
            var numberGroups = from num in numbers2
                               group num by num % 2 == 0 into g
                               select new { IsEven = g.Key, Numbers = g };

            foreach (var group in numberGroups)
            {
                Console.WriteLine(group.IsEven ? "Even numbers:" : "Odd numbers:");
                foreach (var num in group.Numbers)
                {
                    Console.WriteLine(num);
                }
            }



            //5.Joining Data from Multiple Sources
            List<Student> students = new List<Student>
            {
                new Student { ID = 1, Name = "Alice" },
                new Student { ID = 2, Name = "Bob" },
                new Student { ID = 3, Name = "Carol" }
            };

            List<Course> courses = new List<Course>
            {
                new Course { CourseID = 1, CourseName = "Math" },
                new Course { CourseID = 2, CourseName = "Science" },
                new Course { CourseID = 3, CourseName = "History" }
            };

            // LINQ query to join students and courses
            var studentCourses =
                from student in students
                join course in courses
                    on student.ID equals course.CourseID
                select new { student.Name, course.CourseName };

            foreach (var sc in studentCourses)
            {
                Console.WriteLine($"{sc.Name} is enrolled in {sc.CourseName}");
            }



            //Method Syntax
            List<int> numbers3 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //LINQ method syntax to filter even numbers
            var evenNumbers2 = numbers3.Where(num => num % 2 == 0);

            foreach (var num in evenNumbers2)
            {
                Console.WriteLine(num);
            }


            List<string> names2 = new List<string> { "Alice", "Bob", "Carol", "David" };

            // LINQ method syntax to select names longer than 4 characters
            var longNames2 = names.Where(name => name.Length > 4).Select(name => name.ToUpper());

            foreach (var name in longNames2)
            {
                Console.WriteLine(name);
            }


            List<string> fruits2 = new List<string> { "Apple", "Banana", "Orange", "Grapes" };

            // LINQ method syntax to order fruits alphabetically
            var sortedFruits2 = fruits2.OrderBy(fruit => fruit);

            foreach (var fruit in sortedFruits2)
            {
                Console.WriteLine(fruit);
            }


            List<int> numbers4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // LINQ method syntax to group numbers by even and odd
            var numberGroup2 = numbers4.GroupBy(num => num % 2 == 0);

            foreach (var group in numberGroup2)
            {
                Console.WriteLine(group.Key ? "Even numbers:" : "Odd numbers:");
                foreach (var num in group)
                {
                    Console.WriteLine(num);
                }
            }


            List<Student> students2 = new List<Student>
            {
                new Student { ID = 1, Name = "Alice" },
                new Student { ID = 2, Name = "Bob" },
                new Student { ID = 3, Name = "Carol" }
            };

            List<Course> courses2 = new List<Course>
            {
                new Course { CourseID = 1, CourseName = "Math" },
                new Course { CourseID = 2, CourseName = "Science" },
                new Course { CourseID = 3, CourseName = "History" }
            };

            // LINQ method syntax to join students and courses
            var studentCourses2 =
                students2.Join(
                    courses2,
                    student => student.ID,
                    course => course.CourseID,
                    (student, course) => new
                    {
                        student.Name,
                        course.CourseName
                    });

            foreach (var sc in studentCourses2)
            {
                Console.WriteLine($"{sc.Name} is enrolled in {sc.CourseName}");
            }



            Console.ReadKey();
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
    }
}
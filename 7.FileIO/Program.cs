namespace _7.FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }


        //1.Reading Text from a File
        static void ReadTextFile()
        {
            string filePath = "sample.txt";

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Display the content of the file
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }



        //2.Writing Text to a File
        static void WriteTextFile()
        {
            string filePath = "output.txt";

            // Text to write to the file
            string content = "Hello, File I/O!\nThis is a new line.";

            // Write the content to the file
            File.WriteAllText(filePath, content);

            Console.WriteLine("Content written to the file.");
        }



        //3.Appending Text to a File
        static void AppendFile()
        {
            string filePath = "log.txt";

            // Text to append to the file
            string logEntry = "Error: Division by zero.\n";

            // Append the log entry to the file
            File.AppendAllText(filePath, logEntry);

            Console.WriteLine("Log entry appended to the file.");
        }



        //4.Reading and Writing Binary Data
        static void ReadWriteBinary()
        {
            string filePath = "binary-data.bin";

            // Write binary data to the file
            byte[] dataToWrite = { 0x41, 0x42, 0x43 };
            File.WriteAllBytes(filePath, dataToWrite);

            // Read binary data from the file
            byte[] dataRead = File.ReadAllBytes(filePath);

            Console.WriteLine("Binary data read from the file:");
            foreach (byte b in dataRead)
            {
                Console.Write(b.ToString("X2") + " ");
            }
        }



        //5.Working with Streams
        static void ReadWriteStream()
        {
            string filePath = "stream-data.txt";

            // Writing to a file using StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Line 1");
                writer.WriteLine("Line 2");
                writer.WriteLine("Line 3");
            }

            // Reading from a file using StreamReader
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
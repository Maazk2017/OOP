namespace Practice_Questions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 4
            try
            {
                string content = File.ReadAllText("whatever");
                if (string.IsNullOrWhiteSpace(content))
                {
                    throw new Exception("File is empty");
                }

                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            } catch (EmptyFileException ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            } catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            } 
        }
    }
}

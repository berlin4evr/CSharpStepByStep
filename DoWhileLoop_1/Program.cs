namespace DoWhileLoop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user input");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int i = 0; // Initialize a counter variable

            do // Start of the do-while loop
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
                i++; // Increment the counter
            } while (i <= userInput); // Continue looping until the counter exceeds the user input
        }
    }
}
namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number for print Even numbers");
            int userInput = Convert.ToInt32(Console.ReadLine()); // Reading user input and converting it to an integer

            int i = 0; // Initialize a counter variable

            while (i <= userInput) // Loop until the counter exceeds the user input
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i); // Print the even number
                }
                i++; // Increment the counter
            }
        }
    }
}

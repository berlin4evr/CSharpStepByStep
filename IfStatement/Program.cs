namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int x = number;

            // If statement to check if the number is greater than 5
            if (number > 5)
            {
                Console.WriteLine($"{number} is greater than 5");
            }
            else if (number < 5)
            {
                Console.WriteLine($"{number} is less than 5");
            }
            else
            {
                Console.WriteLine($"{number} is equal to 5");
            }
        }
    }
}

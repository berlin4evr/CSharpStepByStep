namespace SwitchStatement_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 to 15");
            int number = Convert.ToInt32(Console.ReadLine()); // Reading user input and converting it to an integer

            switch (number)
            {
                case 5:
                    Console.WriteLine($"{number} is equal to 5");
                    break;
                case 10:
                    Console.WriteLine($"{number} is equal to 10");
                    break;
                case 15:
                    Console.WriteLine($"{number} is equal to 15");
                    break;
                default:
                    Console.WriteLine($"{number} is not equal to 5, 10, or 15");
                    break;
            }

        }
    }
}

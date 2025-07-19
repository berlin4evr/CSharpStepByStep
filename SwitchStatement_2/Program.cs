namespace SwitchStatement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 to 15");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                // ******* We can use multiple case labels to handle the same logic *******
                case 5:
                case 10:
                case 15:
                    Console.WriteLine($"{number} is equal to {number}");
                    break;
                default:
                    Console.WriteLine($"{number} is not equal to 5, 10, or 15");
                    break;
            }
        }
    }
}

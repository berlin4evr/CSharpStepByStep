namespace ReadAndWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName + "!"); // Output greeting

            Console.WriteLine("Hello {0} {1}!", firstName, lastName); // Output greeting using string interpolation

            Console.WriteLine($"Hello {firstName} {lastName}!"); // Output greeting using string interpolation

        }
    }
}

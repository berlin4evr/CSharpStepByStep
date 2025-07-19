namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.EvenNumber(5); // Call the instance method to check if 5 is even or odd

            Program.EvenNumber(); // Call the static method to print even numbers from 0 to 10
            Program.PrintMessage("Message from Static method to print a message");
        }

        // Static method
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Instance method
        public static void EvenNumber()
        {
            int number = 0;
            while (number <= 10)
            {
                Console.WriteLine(number);
                number = number + 2; // Increment by 2 to get even numbers
            }
        }

        // Instance method with parameter
        public void EvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number {0} is even.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd.", number);
            }
        }
    }
}

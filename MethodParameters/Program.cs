namespace MethodParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            // The original variable remains unchanged because it was passed by value
            Program.PassByValueMethod(i);
            Console.WriteLine("After PassByValue method: " + i); // This will still print 5, not 10

            // The original variable is modified because it was passed by reference
            Program.PassByReferenceMethod(ref i);
            Console.WriteLine("After PassByReference method: " + i); // This will print 10

            // Using out parameters to return multiple values
            int add = 0, multiply = 0;
            Program.PassByOutMethod(5, 10, out add, out multiply);
            Console.WriteLine("After PassByOut method: Addition = " + add + ", Multiplication = " + multiply);

            // Using params to pass a variable number of arguments
            int[] num = { 1, 2, 3 };
            Program.ParameterArrayMethod(); // Calling with no arguments
            Program.ParameterArrayMethod(num); // Passing an array
            Program.ParameterArrayMethod(1, 2, 3, 4, 5); // Passing a variable number of arguments directly

        }

        public static void PassByValueMethod(int number)
        {
            number = 10; // This change will not affect the original variable
            Console.WriteLine("Inside PassByValue method: " + number);
        }

        public static void PassByReferenceMethod(ref int number)
        {
            number = 10; // This change will affect the original variable
            Console.WriteLine("Inside PassByReference method: " + number);
        }

        // This method uses out parameters to return multiple values
        public static void PassByOutMethod(int a, int b, out int addition, out int multiplication)
        {
            addition = a + b; 
            multiplication = a * b;
            Console.WriteLine("Inside PassByOut method: Addition = {0} and Multiplication = {1} ", addition, multiplication);
        }

        public static void ParameterArrayMethod(params int[] numbers)
        {
            Console.WriteLine("Numbers in the array {0}", numbers.Length);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}

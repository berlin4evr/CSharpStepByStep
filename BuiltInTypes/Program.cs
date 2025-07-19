namespace BuiltInTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boolean - true or false values
            // Integer types - sbyte, byte, short, ushort, int, uint, long, ulong
            // Floating-point types - float, double, decimal
            // Character type - char
            // String type - string
            // Nullable types - int?, double?, etc.

            // Example of using built-in types
            bool isActive = true; // Boolean type
            int age = 30; // Integer type
            double height = 5.9; // Floating-point type
            char initial = 'M'; // Character type
            string name = "Dhileeban"; // String type
            decimal balance = 1000.50m; // Decimal type for financial calculations
            Console.WriteLine($"Name: {name}, Initial: {initial}, Age: {age}, Height: {height}, Active: {isActive}, Balance: {balance}");

            // Example of using nullable types
            int? nullableInt = null; // Nullable integer type

            Console.WriteLine($"Nullable Integer: {nullableInt}");

            // Example for find min and max values of integer types
            Console.WriteLine("Min {0} ", int.MinValue);
            Console.WriteLine("Max {0} ", int.MaxValue);

            // Escape sequences in strings
            string escapedString = "Hello, \"World\"!\nThis is a new line.\tThis is a tab.";
            Console.WriteLine(escapedString);

            // String interpolation
            string firstName = "Dhileeban";
            string lastName = "M";
            Console.WriteLine($"Hello, {firstName} {lastName}!");

            // Backslash in strings
            string filePath = "C:\\Users\\Dhileeban\\Documents\\file.txt"; // Using double backslashes to escape
            Console.WriteLine($"File Path: {filePath}");

            // verbatim strings
            string verbatimString = @"C:\Users\Dhileeban\Documents\file.txt"; // Using @ to treat backslashes as literal characters
            Console.WriteLine($"Verbatim String: {verbatimString}");
        }
    }
}

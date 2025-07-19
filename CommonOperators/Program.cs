namespace CommonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Common Operators in C#
            // This program demonstrates the use of various operators in C#
            // Operators include Arithmetic, Comparison, Logical, Ternary, and Null-coalescing operators

            // Assignment Operators: =, +=, -=, *=, /=, %=
            Console.WriteLine("Asignment Operators in C#");
            int a = 100, b = 2;
            Console.WriteLine("a = {0}, b = {1}", a, b);


            // Arithmetic Operators: +, -, *, /, %
            Console.WriteLine("Arithmetic Operators in C#");
            int sum = a + b; // Addition
            Console.WriteLine("Addition " + sum);

            int difference = a - b; // Subtraction
            Console.WriteLine("Subtraction " + difference);

            int product = a * b; // Multiplication
            Console.WriteLine("Multiplication " + product);

            int quotient = a / b; // Division will give remainder
            int remainder = a % b; // Modulus will give quotient
            Console.WriteLine("Division {0} Modulus {1}", quotient, remainder);


            // Comparison Operators: ==, !=, <, >, <=, >=
            Console.WriteLine("Comparison Operators in C#");
            if (a == b) // Equality
            {
                Console.WriteLine("a is equal to b");
            }
            else if (a != b) // Inequality
            {
                Console.WriteLine("a is not equal to b");
            }


            // Logical Operators: &&, ||, !
            Console.WriteLine("Logical Operators in C#");
            if (a > b && a < 200) // Logical AND
            {
                Console.WriteLine("a is greater than b and less than 200");
            }
            if (a < b || a > 50) // Logical OR
            {
                Console.WriteLine("a is less than b or greater than 50");
            }


            // Ternary Operator: condition ? true_expression : false_expression
            Console.WriteLine("Ternary Operator in C#");
            string result = (a > b) ? "a is greater than b" : "a is not greater than b"; // Ternary operation
            Console.WriteLine("Ternary operator result = " + result);


            // null-coalescing operator: ??
            Console.WriteLine("Null-coalescing Operator in C#");
            string? nullableString = null; // Nullable string
            string nonNullableString = nullableString ?? "Default Value"; // If nullableString is null, use "Default Value"
            Console.WriteLine("Null-coalescing operator result = " + nonNullableString);

        }
    }
}

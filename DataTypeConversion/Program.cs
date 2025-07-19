namespace DataTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit and Explicit Type Conversion in C#
            // Implicit Conversion (widening conversion)

            // Implicitly converting int to double
            int intValue = 123;
            double doubleValue = intValue; // Implicitly converting int to double
            Console.WriteLine($"Implicit Conversion: int {intValue} to double {doubleValue}");


            // Explicit Conversion (narrowing conversion)
            double anotherDoubleValue = 123.45; // Double type
            int anotherIntValue = (int)anotherDoubleValue; // Explicitly converting double to int
            Console.WriteLine(anotherIntValue);


            //-----------------------------USING TRY PARSE-----------------------------------------------------
            string strNumber = "456T"; // String representation of a number
            bool isConversionSuccessful = int.TryParse(strNumber, out int result);

            // Attempting to convert string to int using TryParse
            if (isConversionSuccessful)
            {
                Console.WriteLine($"String '{strNumber}' converted to int: {result}");
            }
            else
            {
                Console.WriteLine($"Failed to convert string '{strNumber}' to int.");
            }
            //----------------------------------------------------------------------------------

        }
    }
}

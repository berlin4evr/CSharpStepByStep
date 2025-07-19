namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5]; // Declare an array of integers with a size of 5
            // The array is initialized with default values (0 for integers)
            // Assign values to the array
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            
            Console.WriteLine("Array values:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
        }
    }
}

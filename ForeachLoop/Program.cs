namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            // Using foreach loop to iterate through the array
            foreach (int n in numbers)
            {
                Console.WriteLine("The value of number is {0}", n);
            }

            // Alternatively, using a foreach loop with an index
            int index = 0;
            foreach (int i in numbers)
            {
                Console.WriteLine("The value of number[{0}] is {1}", index, i);
                index++;
            }
        }
    }
}

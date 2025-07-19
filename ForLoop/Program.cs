namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3];
            number[0] = 10;
            number[1] = 20;
            number[2] = 30;

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine("The value of number[{0}] is {1}", i, number[i]);
            }

            // Alternatively, using a for loop with a different condition
            for (int j = 0; j <= 10; j++)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine("The value of j is {0} and it is even", j);
                }
                else
                {
                    Console.WriteLine("The value of j is {0} and it is odd", j);
                }
            }

            // for loop with a break statement
            for (int k = 0; k < 10; k++)
            {
                if (k == 5)
                {
                    Console.WriteLine("Breaking the loop at k = {0}", k);
                    break; // Exit the loop when k equals 5
                }
                Console.WriteLine("The value of k is {0}", k);
            }


            // for loop with a continue statement
            for (int l = 0; l < 10; l++)
            {
                if (l % 2 == 0)
                {
                    Console.WriteLine("Skipping even number: {0}", l);
                    continue; // Skip the rest of the loop for even numbers
                }
                Console.WriteLine("The value of l is {0} and it is odd", l);
            }
        }
    }
}

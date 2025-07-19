namespace DoWhileLoop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCoffeeCost = 0;
            string userDecision = string.Empty;
            do
            {
                int userChoice = -1;
                do
                {
                    Console.WriteLine("Select your coffee : 1-small 2-Medium 3-Large");
                    userChoice = Convert.ToInt32(Console.ReadLine()); // Reading user input and converting it to an integer

                    switch (userChoice)
                    {
                        case 1:
                            totalCoffeeCost += 10; // Add cost for small coffee
                            Console.WriteLine("You selected Small Coffee. Cost: $10");
                            break;
                        case 2:
                            totalCoffeeCost += 20; // Add cost for small coffee
                            Console.WriteLine("You selected Small Coffee. Cost: $20");
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid. Please select 1, 2, or 3.", userChoice);
                            break;
                    }
                } while (userChoice < 1 || userChoice > 3); // Ensure valid choice

                do
                {
                    Console.WriteLine("Do you want to order more coffee? (y/n)");
                    userDecision = Console.ReadLine().ToLower().Trim(); // Read user input and convert to lowercase

                    if (userDecision != "y" && userDecision != "n")
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' for yes or 'n' for no.");
                    }
                } while (userDecision != "y" && userDecision != "n"); // Ensure valid decision
            } while (userDecision == "y"); // Continue ordering if user decides to order more

            Console.WriteLine("Thank you for your order!");
            Console.WriteLine("Total cost of your coffee is: ${0}", totalCoffeeCost); // Print total cost
        }
    }
}

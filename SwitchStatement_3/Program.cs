namespace SwitchStatement_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPizzaCost = 0; // Variable to hold the total cost of the pizza

        ParameterizedThreadStart:
            Console.WriteLine("Select your Pizza: 1- Small, 2-Medium. 3-Large");
            int userChoice = Convert.ToInt32(Console.ReadLine()); // Reading user input and converting it to an integer

            switch (userChoice)
            {
                case 1:
                    totalPizzaCost += 1; // Cost for small pizza
                    Console.WriteLine($"You have selected Small Pizza. Total cost is {totalPizzaCost} USD.");
                    break;
                case 2:
                    totalPizzaCost += 2; // Cost for medium pizza
                    Console.WriteLine($"You have selected medium Pizza. Total cost is {totalPizzaCost} USD.");
                    break;
                case 3:
                    totalPizzaCost += 3; // Cost for large pizza
                    Console.WriteLine($"You have selected large Pizza. Total cost is {totalPizzaCost} USD.");
                    break;
                default:
                    Console.WriteLine($"Your choice {userChoice} is Invalid. Please select 1 for small, 2 for Medium, or 3 for Large pizza size.");
                    goto ParameterizedThreadStart;
            }

        ParameterizedThreadStartuserDecision:
            Console.WriteLine("Do you want to another Pizza? (y/n)");
            string userDecision = Console.ReadLine()?.ToLower(); // Reading user input for another pizza choice  

            switch (userDecision)
            {
                case "y":
                    Console.WriteLine("You have chosen to order another pizza.");
                    goto ParameterizedThreadStart; // Go back to the pizza selection
                case "n":
                    Console.WriteLine("You have chosen not to order another pizza.");
                    break;
                default:
                    Console.WriteLine($"Your choice {userDecision} is Invalid. Please select 'y' for yes or 'n' for no.");
                    goto ParameterizedThreadStartuserDecision; // Go back to the userDecision
            }

            Console.WriteLine("Thank you for your order!"); // Final message after the order is complete
            Console.WriteLine($"Your total pizza cost is {totalPizzaCost} USD."); // Display the total cost of the pizza

        }
    }
}

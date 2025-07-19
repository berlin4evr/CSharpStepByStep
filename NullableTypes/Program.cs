namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value types can be null using nullable types
            int? nullableInt = null; // Nullable integer
            double? nullableDouble = null; // Nullable double
            Console.WriteLine("Nullable Integer: " + nullableInt);
            Console.WriteLine("Nullable Double: " + nullableDouble);


            /* ------- Null -coalescing operator Example------ */
            // The null-coalescing operator (??) provides a default value if the left operand is null
            int? TicketsOnSale = null; // Nullable integer for tickets on sale
            int defaultTickets = 100; // Default number of tickets
            // Using null-coalescing operator to provide a default value if TicketsOnSale is null
            int ticketsToDisplay = TicketsOnSale ?? defaultTickets; // If TicketsOnSale is null, use defaultTickets
            Console.WriteLine("Tickets on Sale: " + ticketsToDisplay);
        }
    }
}

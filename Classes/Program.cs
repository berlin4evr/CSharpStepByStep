namespace Classes
{
    class Customer
    {
        string _firstName;
        string _lastName;

        // Constructor - Initializes a new instance of the Customer class
        public Customer(string firstName, string lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public void PrintFullName()
        {
            System.Console.WriteLine($"Full Name: {this._firstName} {this._lastName}");
        }

        ~Customer()
        {
            // Destructor - Cleans up resources when the object is no longer needed
            // This is called when the object is being garbage collected
            // CLR will call this automatically. No need to call it explicitly.
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Dhileeban", "M");
            customer.PrintFullName();
        }
    }
}

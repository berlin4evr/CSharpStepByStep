namespace MethodHiding
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void PrintFullName()
        {
            Console.WriteLine($"Full Name: {firstName} {lastName}");
        }
    }

    public class FullTimeEmployee : Employee
    {
        // Method hiding using new keyword
    }

    public class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine($"Full Name: {firstName} {lastName} - PartTime Employee");
            base.PrintFullName(); // Call the base class method
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.firstName = "Dhileeban";
            fullTimeEmployee.lastName = "M";
            fullTimeEmployee.PrintFullName();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.firstName = "Berlin";
            partTimeEmployee.lastName = "M";
            partTimeEmployee.PrintFullName();
        }
    }
}

namespace Inheritance
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintDetails()
        {
            System.Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public decimal yearlySalary { get; set; }
        public void PrintSalary()
        {
            System.Console.WriteLine($"Salary: {yearlySalary}");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public decimal hourlyRate { get; set; }
        public int hoursWorked { get; set; }
        public void PrintHourlyWage()
        {
            System.Console.WriteLine($"Hourly Rate: {hourlyRate}, Hours Worked: {hoursWorked}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "Dhileeban";
            fullTimeEmployee.LastName = "M";
            fullTimeEmployee.yearlySalary = 60000;
            fullTimeEmployee.PrintDetails();
            fullTimeEmployee.PrintSalary();

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.FirstName = "Berlin";
            partTimeEmployee.LastName = "M";
            partTimeEmployee.hourlyRate = 20;
            partTimeEmployee.hoursWorked = 15;
            partTimeEmployee.PrintDetails();
            partTimeEmployee.PrintHourlyWage();
        }
    }
}

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

// ************************ Documentation **************************
//  A namespace declaration is required in C# files. It's used to organize code and prevent naming conflicts.
//  The namespace 'HelloWorld' is defined to encapsulate the Program class.
//  The Program class contains the Main method, which is the entry point of the application.
//  The Main method prints "Hello, World!" to the console.
//  The code is structured to be compatible with .NET 8.0, as indicated by the target framework in the project file.
//  The code uses the 'internal' access modifier for the Program class, which restricts its visibility to the current assembly.
//  The 'static' keyword indicates that the Main method belongs to the Program class itself, not to instances of the class.
//  The 'args' parameter in the Main method allows for command-line arguments to be passed to the application.
//  The Console.WriteLine method is used to output text to the console.
//  The code is written in C# and follows the conventions for a simple console application.
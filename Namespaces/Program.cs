using System;
using PATA = ProjectA.TeamA; // Importing the namespace for ClassA in TeamA
using PATB = ProjectA.TeamB; // Importing the namespace for ClassA in TeamB
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        PATA.ClassA.DisplayMessage(); // Call the static method from ClassA in ProjectA.TeamA
        PATB.ClassA.DisplayMessage(); // Call the static method from ClassA in ProjectA.TeamB

    }
}


namespace ProjectA
{
    namespace TeamA
    {
        public class ClassA
        {
            public static void DisplayMessage()
            {
                Console.WriteLine("Hello from ClassA in ProjectA.Team-A");
            }
        }
    }
}


namespace ProjectA
{
    namespace TeamB
    {
        public class ClassA
        {
            public static void DisplayMessage()
            {
                Console.WriteLine("Hello from ClassA in ProjectA.Team-B");
            }
        }
    }
}

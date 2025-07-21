namespace MethodHiding_2
{
    public class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("From Base Class");
        }

    }

    public class DerivedClass1 : BaseClass
    {
        public new void Display() // new Keyword can hide the method from base class
        {
            Console.WriteLine("From Derived Class1 - Display() Method - Added new keyword");
            base.Display(); // to call the base method use base keyword
        }
    }

    public class DerivedClass2: DerivedClass1
    {
        //public void Display()
        //{
        //    Console.WriteLine("From Derived Class2 - Display() Method");
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.Display();

            DerivedClass1 derivedClass1 = new DerivedClass1();
            derivedClass1.Display();

            DerivedClass2 derivedClass2 = new DerivedClass2();
            derivedClass2.Display();
        }
    }
}

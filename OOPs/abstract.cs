using System;

namespace Program
{
    // Abstract class
    abstract public class baseClass
    {
        public string absName = "Abstarct class";

        public void method()
        {
            Console.WriteLine("Abstract class method");
        }
    }

    // Abstarct class can be used in drived class
    public class subClass : baseClass
    {
        public string subName = "Sub class";

        public void function()
        {
            Console.WriteLine("Sub class method");
        }
    }

    class mainClass
    {
        static void Main(string[] args)
        {
            // Can not create a object of abstract class 
            // baseClass o = new baseClass();

            // Abstract class can be used in the drived class
            subClass obj = new subClass();

            // Access the sub class field and method
            Console.WriteLine(obj.subName);
            obj.function();

            // Access  the abstract class field and method
            Console.WriteLine(obj.absName);
            obj.method();
        }
    }
}


/*
Output:
-------
    Sub class
    Sub class method
    Abstarct class
    Abstract class method
*/
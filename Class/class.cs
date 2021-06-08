using System;

namespace Program
{
    class Program
    {
        // Creating a class
        class className
        {
            // Class field or attribute
            public int variable = 10;

            // Class method definition
            public void classMethod()
            {
                Console.WriteLine("I am in class method");
            }
        }

        static void Main(string[] args)
        {
            // Create an object
            className obj = new className();

            // Access the class field or attribute
            Console.WriteLine("Class variable name : " + obj.variable);

            // Access the class method
            obj.classMethod();

            // can create multiple object of one class
            // Example
            className obj2 = new className();
            obj2.variable = 200;
            Console.WriteLine(obj2.variable);
        }
    }
}

using System;

namespace Program
{
    class Program
    {
        // Creating a class
        class className
        {
            // Class member
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

            // Access the class member
            Console.WriteLine("Class variable name : " + obj.variable);

            // Access the class method
            obj.classMethod();
        }
    }
}

using System;

namespace Program
{
    class Program
    {
        // Creating a class
        sealed class sealedClass
        {
            // Class field or attribute
            public string name => "Sealed Class";

            // Class method definition
            public void printClassName()
            {
                Console.WriteLine("Class name: " + name);
            }
        }

        static void Main(string[] args)
        {
            // Create an object
            sealedClass obj = new sealedClass();

            // Access the class method
            obj.printClassName();
        }
    }
}


/*
Output:
-------
    Class variable name : 10
    I am in class method
    200
*/
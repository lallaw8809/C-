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

        // Can not inheritance the sealed class. This will throw an error as below
        // cannot derive from sealed type 'Program.sealedClass'
        // public class InheritenceClass: sealedClass
        // {
        // }

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
    Class name: Sealed Class
*/
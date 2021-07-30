using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accessing the first constructor
            sampleClass obj1 = new sampleClass();

            // Accessing the secod constructor
            sampleClass obj2 = new sampleClass(12);

            // Accessing the thrid constructor
            sampleClass obj3 = new sampleClass(100, "Lal Bosco");
            Console.WriteLine();

            // Example of calling constructor
            callingConstructor obj4 = new callingConstructor();
            Console.WriteLine();

            // Example of static class
            // Static constructor is getting called first and followed by default construct will get get called
            staticConstructor obj5 = new staticConstructor();
            Console.WriteLine();

            Console.WriteLine("Calling the static constructor second time...");
            staticConstructor obj6 = new staticConstructor(); // Deafult constructor is getting called
        }
    }

    // Multiple constructor (method overloading)
    public class sampleClass
    {
        public sampleClass()
        {
            Console.WriteLine("First constructor");
        }

        public sampleClass(int x)
        {
            Console.WriteLine("Sencond constructor: value of i {0}", x);
        }

        public sampleClass(int x, string name)
        {
            Console.WriteLine("Thrid constructor: value {0} name {1}", x, name);
        }
    }

    // Calling Constructor from another Constructor
    public class callingConstructor
    {
        // It will call the second constructor first and followed by runs the first constructor
        public callingConstructor() : this(10)
        {
            Console.WriteLine("First calling constructor");
        }

        public callingConstructor(int x)
        {
            Console.WriteLine("Sencond calling constructor: value of i {0}", x);
        }

    }

    // Sample static constructor
    public class staticConstructor
    {
        static staticConstructor()
        {
            Console.WriteLine("Static constructor called");
        }

        public staticConstructor()
        {
            Console.WriteLine("Default constructor called");
        }

    }
}


/*
Output:
-------
    First constructor
    Sencond constructor: value of i 12
    Thrid constructor: value 100 name Lal Bosco

    Sencond calling constructor: value of i 10
    First calling constructor

    Static constructor called
    Default constructor called

    Calling the static constructor second time...
    Default constructor called
*/
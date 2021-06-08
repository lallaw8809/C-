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

            // Example of calling constructor
            callingConstructor obj4 = new callingConstructor();

            // Example of static class
            // Static constructor is getting called first and followed by default construct will get get called
            staticConstructor onj5 = new staticConstructor();
            staticConstructor onj6 = new staticConstructor(); // Deafult constructor is getting called
        }
    }

    // Multiple constructor
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
        // It will call the second constructor and followed by runs the first constructor
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
        static staticClass()
        {
            Console.WriteLine("Static constructor called");
        }

        public staticClass()
        {
            Console.WriteLine("Default constructor called");
        }

    }
}

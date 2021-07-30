using System;
namespace Polymorphism
{
    // Method overlaoding example
    class A
    {
        public void func()
        {
            Console.WriteLine("Class A without param");
        }

        public void func(int x)
        {
            Console.WriteLine("Class A with param : {0}", x);
        }
    }


    // Method overriding example 
    class IndiaStates
    {
        public virtual void language()
        {
            Console.WriteLine("Each state people speaks diffent launges");
        }
    }

    class TamilNadu : IndiaStates
    {
        public override void language()
        {
            Console.WriteLine("TamilNadu state people speaks Tamil");
        }
    }

    class Andrapradesh : IndiaStates
    {
        public override void language()
        {
            Console.WriteLine("Andrapradesh state people speaks Telugu");
        }
    }
    
    class Kerala : IndiaStates
    {
        public override void language()
        {
            Console.WriteLine("Kerala state people speaks Malayalam");
        }
    }


    // Method hiding
    class Parent
    {
        public virtual void printName()
        {
            Console.WriteLine("I am in parent class");
        }
    }

    class Child : Parent
    {
        public new void printName()
        {
            Console.WriteLine("I am in child class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // METHOD OVERLOADING
            Console.WriteLine("Example of METHOD OVERLOADING");
            // Accessing the method overloading
            A a = new A();
            a.func();   // o/p: Class A without param
            a.func(10); // o/p: Class A with param : 10
            Console.WriteLine();

            // METHOD OVERRIDING
            Console.WriteLine("Example of METHOD OVERRIDING");
            IndiaStates[] states = new IndiaStates[4];

            states[0] = new IndiaStates();
            states[1] = new TamilNadu();
            states[2] = new Andrapradesh();
            states[3] = new Kerala();

            // The output will "Each state people speaks diffent launges" if virtual and override is not used.
            // Only the base class method will get called if virtual and override is not used
            states[0].language();
            states[1].language();
            states[2].language();
            states[3].language();

            // another method to call of the methods
            //foreach (IndiaStates s in states)
            //{
            //    s.language();
            //}
            Console.WriteLine();

            // METHOD HIDING
            Console.WriteLine("Example of METHOD HIDING");
            Parent p = new Child();
            p.printName();
            Console.WriteLine();
        }
    }
}

/*
Output:
-------
    Example of METHOD OVERLOADING
    Class A without param
    Class A with param : 10

    Example of METHOD OVERRIDING
    Each state people speaks diffent launges
    TamilNadu state people speaks Tamil
    Andrapradesh state people speaks Telugu
    Kerala state people speaks Malayalam

    Example of METHOD HIDING
    I am in parent class
*/
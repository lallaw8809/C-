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
    class B
    {
        public void method()
        {
            Console.WriteLine("class B");
        }
    }

    class C : B
    {
        public void method()
        {
            Console.WriteLine("Class C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // METHOD OVERLOADING
            // Accessing the method overloading
            A a = new A();
            a.func();   // o/p: Class A without param
            a.func(10); // o/p: Class A with param : 10

            // METHOD OVERRIDING
            B b = new B();
            b.method();

            C c = new C();
            c.method();
        }
    }
}

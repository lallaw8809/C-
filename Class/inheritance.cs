using System;

namespace Program
{
    class Inheritance
    {
        // Base or Parent class
        class Parent
        {
            // Class filed
            public int parentVariable = 10;

            // Class method definition
            public void parentClassMethod()
            {
                Console.WriteLine("I am in class method");
            }
        }

        // Child or drived class
        class Child : Parent
        {
            // Class field
            public int childVariable = 99;

            // Class method definition
            public void childClassMethod()
            {
                Console.WriteLine("I am in class method");
            }
        }
        static void Main(string[] args)
        {
            // Create an object
            Child obj = new Child();

            // Access the inheritance
            Console.WriteLine("Parent Class variable name : " + obj.parentVariable);
            Console.WriteLine("Child Class variable name : " + obj.childVariable);

            // Access the class method
            obj.parentClassMethod();
            obj.childClassMethod();
        }
    }
}

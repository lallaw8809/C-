using System;

// The scope of accessibility is limited within the class or struct
namespace Program
{
    // Error: elements defined in a namespace cannot be declared as private
    // private class OutsideClass
    // {
    // 	private string Name = "OUTSIDE: This is a private variable";
    // 	private void display()
    // 	{
    // 		Console.WriteLine("OUTSIDE: This is a private method");
    // 	}
    // }

    // Error: 'OutsideClass' is innaccessable due to its prection level
    // private class DrivedClass: OutsideClass
    // {
    // }

    public class main
    {
        private class InsidesideClass
        {
            private string Name = "INSIDE: This is a private variable";
            private void display()
            {
                Console.WriteLine("INSIDE: This is a private method");
            }
		
            private int x = 10;
        }

        private class DrivedClass: InsidesideClass
        {
            private void method()
            {
                // Error: x is inaccessable
                // Console.WriteLine(x);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Accessing the INSIDE class variable and method");
            InsidesideClass IC = new InsidesideClass();
            // Error: Can not access the varibale and method as its a private
            // Console.WriteLine(IC.Name);
            // IC.display();
            Console.WriteLine();
        }
    }
}

/*
Output:
-------
    Accessing the INSIDE class variable and method

    Accessing the private varibale from inside the inside the private class
*/
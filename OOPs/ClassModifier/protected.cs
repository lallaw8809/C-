using System;

// The scope of accessibility is limited within the class or struct and the class derived (Inherited )from this class.
namespace Program
{
    // Error: Elements defined in a namespace cannot be declared as private
    // protected class OutsideClass
    // {
    // 	protected string Name = "OUTSIDE: This is a protected variable";
    // 	protected void display()
    // 	{
    // 		Console.WriteLine("OUTSIDE: This is a protected method");
    // 	}
    // }

    // Error: 'OutsideClass' is innaccessable due to its prection level
    // protected class DrivedClass: OutsideClass
    // {
    // }

    public class main
    {
        protected class InsidesideClass
        {
            protected string Name = "INSIDE: This is a public variable";
            protected void display()
            {
                Console.WriteLine("INSIDE: This is a Public method");
            }
            protected int x = 10;
        }

        protected class DrivedClass: InsidesideClass
        {
            protected void method()
            {
                Console.WriteLine(x);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Accessing the INSIDE class variable and method");
            InsidesideClass IC = new InsidesideClass();

            // 'Program.main.InsidesideClass.Name' is inaccessible due to its protection level
            // Console.WriteLine(IC.Name);

            // 'Program.main.InsidesideClass.display' is inaccessible due to its protection level
            // IC.display();
            Console.WriteLine();

            Console.WriteLine("Accessing the INSIDE class variable and method from drived class");
            DrivedClass DC = new DrivedClass();

            // 'Program.main.DrivedClass.Name' is inaccessible due to its protection level
            // Console.WriteLine(DC.Name);

            // 'Program.main.DrivedClass.display' is inaccessible due to its protection level
            // DC.display();
			
			// Inaccessable
			// DC.method();
            Console.WriteLine();
        }
    }
}

/*
Output:
-------
Accessing the INSIDE class variable and method

Accessing the INSIDE class variable and method from drived class
*/
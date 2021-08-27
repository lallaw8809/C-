using System;

namespace Program
{
    public class OutsideClass
    {
        public string Name = "OUTSIDE: This is a public variable";
        public void display()
        {
            Console.WriteLine("OUTSIDE: This is a Public method");
        }
    }

    public class DrivedClass: OutsideClass
    {
    }

    public class main
    {
        public class InsidesideClass
        {
            public string Name = "INSIDE: This is a public variable";
            public void display()
            {
                Console.WriteLine("INSIDE: This is a Public method");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Accessing the INSIDE class variable and method");
            InsidesideClass IC = new InsidesideClass();
            Console.WriteLine(IC.Name);
            IC.display();
            Console.WriteLine();

            Console.WriteLine("Accessing the OUTSIDE class variable and method");
            OutsideClass OC = new OutsideClass();
            Console.WriteLine(OC.Name);
            OC.display();
            Console.WriteLine();

            Console.WriteLine("Accessing the OUTSIDE class variable and method from drived class");
            DrivedClass DC = new DrivedClass();
            Console.WriteLine(DC.Name);
            DC.display();
            Console.WriteLine();
        }
    }
}

/*
Output:
-------
    Accessing the INSIDE class variable and method
    INSIDE: This is a public variable
    INSIDE: This is a Public method

    Accessing the OUTSIDE class variable and method
    OUTSIDE: This is a public variable
    OUTSIDE: This is a Public method

    Accessing the OUTSIDE class variable and method from drived class
    OUTSIDE: This is a public variable
    OUTSIDE: This is a Public method
*/
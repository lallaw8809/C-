using System;

namespace Program
{
    // Static classes and static Member
    public static class Calculator
    {
        // Class member
        public static string name;

        public static int add(int a, int b)
        {
            return a+b;
        }
        public static int mul(int a, int b)
        {
            return a * b;
        }

        // Class method definition
        public static void displayName()
        {
            Console.WriteLine("Name : {0}", name);
        }
    }

    class mainClass
    {
        static void Main(string[] args)
        {
            // Calling the static class method
            int add = Calculator.add(10, 5);
            Console.WriteLine("Adding two numbers : {0}", add);

            int mul = Calculator.mul(10, 5);
            Console.WriteLine("Adding two numbers : {0}", mul);

            // Update the class member
            Calculator.name = "Phonak";
            Calculator.displayName();
        }
    }
}

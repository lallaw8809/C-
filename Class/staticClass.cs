using System;

namespace Program
{
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
            Calculator.name = "Phonka";
            Calculator.displayName();
        }
    }

    /* Static classes and static Member
        A static class cannot be instantiated.
        Can not use a new operator to create a variable type of the class type (No instance variable).
        Contains only static members.
        Cannot contain Instance Constructors.
        It is sealed so we can not inheritance the static class
     */
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
}

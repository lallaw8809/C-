using System;

namespace Program
{
    class Program
    {
        public const double PI = 3.14;
        public static readonly string name;

        static Program()
        {
            name = "Lal Bosco";
            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
           // Can change the value of the name (readonly varible) in the constractor
            Program obj = new Program(); 

            // As both of them (PI and name) are constant, we can not change the value here
            // obj.PI = 12.09; // Can not change the value
            //obj.name = "Terik"; // can change the value here      
        }
    }
}

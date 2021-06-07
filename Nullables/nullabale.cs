using System;

namespace Program
{
    class main
    {
        static void Main(string[] args)
        {
            /* It is special type of  datatypes in c# and we can stre a range of the value from 
             *  -2,147,483,648 to 2,147,483,647 or null
             *  
             *  Syntex
             *  < data_type> ? <variable_name> = null;
             */

            int? variable1 = null;
            int? variable2 = 19832948;
            int? variable3 = new int?();

            Console.WriteLine(" Value of variable1: {0}", variable1);
            Console.WriteLine(" Value of variable2: {0}", variable2);
            Console.WriteLine(" Value of variable3: {0}", variable3);

            // The Null Coalescing Operator (??)
            // If the value is not assigned to variable then its assing the value
            int number1;
            int number2;

            number1 = variable1 ?? 5;
            Console.WriteLine(" Value of number1: {0}", number1);

            number2 = variable2 ?? 5;
            Console.WriteLine(" Value of number2: {0}", number2);
        }
    }
}

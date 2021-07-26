using System;

namespace in_modifier
{
    class program
    {
        static void Modify_variable(in bool variable)
        {
            // We can only read the variable and can not modify here
            // variable = flase; // it will throw an error

            if (variable)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        static void Main()
        {
            bool x = true;
            Modify_variable(in x);
        }
    }
}


// Output:

// True
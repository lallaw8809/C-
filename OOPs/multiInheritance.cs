using System;

namespace Program
{
    class Inheritance
    {
        class A
        {
            // Class field
            public string Name = "Lal Bosco";

            // Class method definition
            public void getName()
            {
                Console.WriteLine("Name : " + Name);
            }
        }

        class B : A
        {
            // Class field
            public string profession = "Software Developer";

            // Class method definition
            public void getProfession()
            {
                Console.WriteLine("Professtion : {0}", profession);
            }
        }

        class C : B
        {
            // Class field
            public string company;

            // Class method definition
            public void getCompany()
            {
                Console.WriteLine("Professtion : {0}", company);
            }
        }

        static void Main(string[] args)
        {
            // Create an object
            C obj = new C();

            // Update the company
            obj.company = "XXXX";

            obj.getName();
            obj.getProfession();
            obj.getCompany();
        }
    }
}

/*
Output:
-------
    Name : Lal Bosco
    Professtion : Software Developer
    Professtion : XXXX
*/
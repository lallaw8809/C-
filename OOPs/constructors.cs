using System;

namespace Program
{
    class main
    {
        static void Main(string[] args)
        {
            // Create an object
            constructor1 obj1 = new constructor1();
            Console.WriteLine("Contruct type1 : " + obj1.Name);
            Console.WriteLine();

            constructor2 obj2 = new constructor2("Bosco");
            Console.WriteLine("Contruct type2 : " + obj2.Name);
            Console.WriteLine();

            constructor3 obj3 = new constructor3("Tamil", 3000, "Tamil Nadu");
            Console.WriteLine("Contruct type3 Name : " + obj3.Name);
            Console.WriteLine("Contruct type3 Age : " + obj3.age);
            Console.WriteLine("Contruct type3 Location : " + obj3.location);
            Console.WriteLine();

            constructor4 obj4 = new constructor4();
            obj4.Name = "Kanya Kumari";
            obj4.age = 50;
            obj4.location = "South India";
            Console.WriteLine("Contruct type4 Name : " + obj4.Name);
            Console.WriteLine("Contruct type4 Age : " + obj4.age);
            Console.WriteLine("Contruct type4 Location : " + obj4.location);
            Console.WriteLine();

            constructor4 obj44 = new constructor4("Malayalam", 2000, "Kerala");
            Console.WriteLine("Contruct type4 Name : " + obj44.Name);
            Console.WriteLine("Contruct type4 Age : " + obj44.age);
            Console.WriteLine("Contruct type4 Location : " + obj44.location);
            Console.WriteLine();

            // Declare a constructor4 by using an object initializer 
            constructor4 objInit = new constructor4
            {
                Name = "Lal Bosco",
                age = 32,
                location = "TamilNadu"
            };

            Console.WriteLine(objInit.ToString());
        }
    }

    class constructor1
    {
        // Class member
        public string Name;

        // Class method definition
        public constructor1()
        {
            Name = "Lal";
        }
    }

    class constructor2
    {
        // Class field
        public string Name;

        // Class method definition
        public constructor2(string myName)
        {
            Name = myName;
        }
    }

    class constructor3
    {
        // Class fields
        public string Name;
        public int age;
        public string location;

        // Class method definition
        public constructor3(string myName, int myAge, string myLocation)
        {
            Name = myName;
            age = myAge;
            location = myLocation;
        }
    }

    class constructor4
    {
        // Class fields
        public string Name;
        public int age;
        public string location;

        public constructor4()
        {
        }

        // Create a class constructor with multiple parameters
        public constructor4(string myName, int myAge, string myLocation)
        {
            Name = myName;
            age = myAge;
            location = myLocation;
        }

        public override string ToString() => Name + "  " + age + " " + location;
    }
}

/*
Output:
-------
    Contruct type1 : Lal

    Contruct type2 : Bosco

    Contruct type3 Name : Tamil
    Contruct type3 Age : 3000
    Contruct type3 Location : Tamil Nadu

    Contruct type4 Name : Kanya Kumari
    Contruct type4 Age : 50
    Contruct type4 Location : South India

    Contruct type4 Name : Malayalam
    Contruct type4 Age : 2000
    Contruct type4 Location : Kerala

    Lal Bosco  32 TamilNadu
*/
using System;

namespace Program
{
    class main
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Orange", "Banna", "Mango" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }
    }
}

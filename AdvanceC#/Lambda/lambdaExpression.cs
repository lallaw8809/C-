using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> Numbers = new List<int>()
        {1,2,3,4,5,6,7,8,9};

        // Mulitply by 2
        Console.WriteLine("Mulitply by 2");
        var MultiplyValues = Numbers.Select(x => x*2);

        foreach (var num in MultiplyValues)
        {
            Console.WriteLine("\t" + num);
        }

        // Divide by 2
        Console.WriteLine("Divide by 2");
        var DivideByTwo = Numbers.FindAll(x => (x % 2) == 0);

        foreach (var num in DivideByTwo)
        {
            Console.WriteLine("\t" + num);
        }
    }
}

/*
Output:

Mulitply by 2
    2
    4
    6
    8
    10
    12
    14
    16
    18

Divide by 2
    2
    4
    6
    8
*/
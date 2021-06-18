using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        List<int> years = new List<int>(){1990, 1991, 1992, 1993, 1994, 2001, 2021};

        // Convert the list into IEnumerable
        IEnumerable<int> ienun = (IEnumerable <int>) years;

        // It will not remember (same as array with index) which index it is executing
        Console.WriteLine("Printing all off List with IEnumerable method : ");
        foreach (int year in ienun)
        {
            Console.WriteLine(year);
        }
        Console.WriteLine();
    }  
}

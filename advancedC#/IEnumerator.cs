using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        List<int> years = new List<int>(){1990, 1991, 1992, 1993, 1994, 2001, 2021};

        // Convert the list into Enumerator
        Console.WriteLine("Printing all off List with IEnumerator method : ");
        IEnumerator<int> ienumerat = years.GetEnumerator();
        // It will remember which index it is executing
        while (ienumerat.MoveNext())
        {
            Console.WriteLine(ienumerat.Current.ToString());
        }
    }
}

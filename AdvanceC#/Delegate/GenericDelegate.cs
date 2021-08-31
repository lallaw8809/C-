  
using System;

public class Example
{
    // T (Generic type parameter or datatype) can be used as any datatypes
	
    // Single Generic Type
    // Example is shown for int and string
    public delegate T SingleGenericType<T>(T a, T b);

    public static int AddTwoNumbers(int x, int y)
    {
        return x + y;
    }

    public static string concatenateString(string m1, string m2)
    {
        return m1 + m2;
    }
	
    // Muultiple Generic Type
    public delegate T MultiGenericType<T, V>(T a, V b);

    public static int AddMultiNumbers(int x, bool y)
    {
        if (y)
        {
            return x;
        }

        return 0;
    }
	
    public static void Main()
    {
		// Single Generic Type
        SingleGenericType<int> Del = AddTwoNumbers;

        int sum = Del.Invoke(12, 23);
        Console.WriteLine("Adding two numberes: " + sum);

        SingleGenericType<string> con = concatenateString;

        string msg = con.Invoke("Hello ", "World");
        Console.WriteLine("concentrating  two strings: " + msg);
		
        // Muultiple Generic Type
        MultiGenericType<int, bool> MulDel = AddMultiNumbers;

        int RetValue = MulDel.Invoke(10, true);
        Console.WriteLine("Muultiple Generic Types return value: " + RetValue);
    }
}

/*
Output:

    Adding two numberes: 35
    concentrating  two strings: Hello World
    Muultiple Generic Types return value: 10
*/
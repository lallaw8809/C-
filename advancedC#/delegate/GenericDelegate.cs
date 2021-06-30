using System;

public class Example
{
    // T (Generic type parameter or datatype) can be used as any datatypes
    // Example is shown for int and string
    public delegate T addTwo<T>(T a, T b);

    public static int methodA(int x, int y)
    {
        return x + y;
    }

    public static string methodB(string m1, string m2)
    {
        return m1 + m2;
    }

    public static void Main()
    {
        addTwo<int> Del = methodA;

        int sum = Del.Invoke(12, 23);
        Console.WriteLine("Adding two numberes: " + sum);

        addTwo<string> con = methodB;

        string msg = con.Invoke("Hello ", "World");
        Console.WriteLine("concentrating  two strings: " + msg);
    }
}
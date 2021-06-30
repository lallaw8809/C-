using System;

public class Example
{

    public delegate void PrintLogsDelegate(string msg);

    public static void methodA(string msg)
    {
        Console.WriteLine(msg);
    }

    public static void methodB(string msg)
    {
        Console.WriteLine(msg);
    }

    static void invokeDelegate(PrintLogsDelegate d, string msg)
    {
        d(msg);
    }

    public static void Main()
    {
        PrintLogsDelegate Del;

        Del = methodA;
        invokeDelegate(Del, "Calling the methodA");

        Del = methodB;
        invokeDelegate(Del, "Calling the methodB");
    }
}
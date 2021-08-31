using System;

public class Program
{
    public static void Main()
    {
        // public delegate TResult Func<in T,out TResult>(T arg);

        // Func<T,TResult> T; input Parammeter and TResult: Return value
        Func<int, int> square = x => x * x;
        Console.WriteLine("Imput parameter 1: " + square(5));

        // Func<T1,T2,TResult> T1 and T2 are input parameters and TResult: Return value
        Func<string, string, bool> CompareString = (x, y) => (x == y);
        Console.WriteLine("Imput parameter 2a: " + CompareString("Hello", "Hello"));
        Console.WriteLine("Imput parameter 2b: " + CompareString("Hello", "World"));
        Console.WriteLine("Hello World");

        // public delegate void Action<in T1,in T2>(T1 arg1, T2 arg2);

        // Action has no return value
        Action line = () => Console.WriteLine("Hello world");
        line();

        Action<int, int> PassArgumentes = (x , y) => Console.WriteLine("Passed Parameters: {0} {1}",x , y);
        PassArgumentes(5, 7);
    }
}

/*
Output:
Imput parameter 1: 25

Imput parameter 2a: True
Imput parameter 2b: False

Hello World
Hello world
Passed Parameters: 5 7
*/
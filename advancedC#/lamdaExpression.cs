using System;
using System.Collections.Generic;
using System.Linq;

public class Example
    {
    public static void LamdaExpressExample()
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
	
    public static void InputParametersLamdaExpression()
    {
        // Input parameters of a lambda expression
        Action line = () => Console.WriteLine();
        line();

        Func<int, int> square = x => x * x;
        Console.WriteLine("Imput parameter 1: " + square(5));

        Func<string, string, bool> CompareString = (x, y) => (x == y);
        Console.WriteLine("Imput parameter 2: " + CompareString("Hello", "Hello"));
        Console.WriteLine("Imput parameter 2: " + CompareString("Hello", "World"));
    }
	
    public static void AsyncLamda()
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
    }

    public static int Main()
    {
        LamdaExpressExample();
        InputParametersLamdaExpression();

        return 0;
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
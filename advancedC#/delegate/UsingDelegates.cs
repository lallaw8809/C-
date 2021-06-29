using System;

public delegate int Calculators(int x, int y);

// lamda expression
MyDelegate del = (string msg) =>  Console.WriteLine(msg);
public class Example
{

    public static int addTwoNumber(int x, int y)
    {
        Console.WriteLine("Adding two numbers ");
        return x + y;
    }

    public static int mulTwoNumber(int x, int y)
    {
        Console.WriteLine("Multiplying two numbers ");
        return x * y;
    }
    public static void Main()
    {
        Calculators cal;
        Calculators add = new Calculators(addTwoNumber);
        Calculators mul = new Calculators(mulTwoNumber);

        cal = add;
        cal += mul;

        // It will call add first followed by mul
        int sum = cal(2, 3);

        Console.WriteLine("Adding two numbers: " + sum);
    }
}
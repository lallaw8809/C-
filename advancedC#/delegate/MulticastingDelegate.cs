// A delegate can point multiple methods.

using System;

public class Example
{
    public delegate int Calculators(int x, int y);
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
        Calculators add = addTwoNumber;
        Calculators mul = mulTwoNumber;

        cal = add;
        cal += mul; // Combines mul

        // It will call add first followed by mul
        int sum = cal(2, 3);

        Console.WriteLine("Adding two numbers: " + sum);

        cal -= mul; // Removes mul

        sum = cal(2, 3); // It will call only the addTwoNumber

        Console.WriteLine("Adding two numbers: " + sum);
    }
}
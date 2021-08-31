/*
 There are three steps are involved in delegate c#

 1. Declare Delegate
 2. Set a target method
 3. Invoke a delegate

*/
using System;

public class Example
{
    // 1. Declare Delegate
    public delegate int addNumbers(int x, int y);

    //  2. Set a target method
    public static int addTwoNumber(int x, int y)
    {
        return x + y;
    }

    public static void Main()
    {
        addNumbers numbers = new addNumbers(addTwoNumber);

        // OR
        // addNumbers numbers = addTwoNumber;
    
        //  3. Invoke a delegate
        int n = numbers(20, 40);

        Console.WriteLine("Adding two numbers: " + n);

        //  3. Invoke a delegate in an another way
        n = numbers.Invoke(2, 8);

        Console.WriteLine("Adding two numbers: " + n);

        // Using lamda expression
        addNumbers num = (int x, int y) => { Console.WriteLine("Lamda expression "); return x+y; };
        n = num(10, 30);
        Console.WriteLine("Adding two numbers using lamda expression: " + n);
    }  
}
/*
 There are three steps are involved in delegate c#

 1. Declare Delegate
 2. Set a target method
 3. Invoke a delegate

*/
using System;

// 1. Declare Delegate
public delegate int addNumbers(int x, int y);

public class Example
{

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
        int n = numbers(23,45);

        Console.WriteLine("Adding two numbers: " + n);
    }  
}
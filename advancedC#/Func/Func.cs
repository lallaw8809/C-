using System;

public class Example
{
    public static int addTwoNumbers(int x, int y)
    {
        return x+y;
    }

    public static int addTwoNumbersByPassingFunc(Func<int, int, int> add)
    {
        int sum = add(5, 6);
        return sum;
    }

    public static TResult addTwoNumbersByPassingFuncType<T, TResult>(T x, T y, Func<T, T, TResult> add)
    {
        TResult sum = add(x, y);
        return sum;
    }

    public static void Main()
    {
        // Func 
        Func<int, int, int> add =  addTwoNumbers;
        int sum = add(1, 2);
        Console.WriteLine("Adding Two numbers using (Func<int, int, int>): " + sum);

        // Func by using lamda
        Func<int, int, int> AddByUsingLamda =  (x, y) => {return x+y;};
        sum = AddByUsingLamda(3, 4);
        Console.WriteLine("Adding Two numbers using Lamda: " + sum);

        // Func as Passing parameters
        sum = addTwoNumbersByPassingFunc(addTwoNumbers);
        Console.WriteLine("Adding Two numbers by passing (Func<int, int, int>): " + sum);

        // Func Passing by Type
        sum = addTwoNumbersByPassingFuncType<int, int>(7, 8, addTwoNumbers);
        Console.WriteLine("Adding Two numbers by passing Func type: " + sum);
    }
}

/*
Output:

    Adding Two numbers using (Func<int, int, int>): 3
    Adding Two numbers using Lamda: 7
    Adding Two numbers by passing (Func<int, int, int>): 11
    Adding Two numbers by passing Func type: 15
*/
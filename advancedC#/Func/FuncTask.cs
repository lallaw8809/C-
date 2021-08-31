using System;
using System.Threading.Tasks;

public class Example
{
    public static int addTwoNumbers(int x, int y)
    {
        return x+y;
    }

    public static async Task<int> addWithTask(int x, int y)
    {
        return await Task.FromResult<int>(addTwoNumbers(x, y));
    }

    public static async Task<int> TaskFuncMethod(Func<int, int, int> FuncMethod)
    {
        return await Task.FromResult<int>(FuncMethod(1, 2));
    }

    public static async Task<int> FuncTaskAsArgument(Func<int, int, Task<int>> FuncMethod)
    {
        return await FuncMethod(3, 4);
    }

    public static void Main()
    {
        // Awaitable Func delegate that returns a value
        Func<int, int, Task<int>> add = async (a, b) =>
        {
        await Task.Delay(100);
        return a + b;
        };
        Task<int> sum = add(5, 5);
        Console.WriteLine("Awaitable Func delegate that returns a value: " + sum.Result);

        // Func with returns the task
        sum = TaskFuncMethod(addTwoNumbers);
        Console.WriteLine("Func: returns the task: " + sum.Result);

        // Func: Pass and return Task
        sum = FuncTaskAsArgument(addWithTask);
        Console.WriteLine("Func: Pass and return Task: " + sum.Result);
    }
}

/*
Output:

    Awaitable Func delegate that returns a value: 10
    Func:  returns the task: 3
    Func: Pass and return Task: 7
*/
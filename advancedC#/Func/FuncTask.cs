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
		// Func with returns the task
		Task<int> sum = TaskFuncMethod(addTwoNumbers);
		Console.WriteLine("Func: returns the task: " + sum.Result);
		
		// Func: Pass and return Task
		sum = FuncTaskAsArgument(addWithTask);
		Console.WriteLine("Func: Pass and return Task: " + sum.Result);
    }
}

/*
Output:
Func:  returns the task: 3
Func: Pass and return Task: 7
*/
using System;
using System.Threading.Tasks;

public class Program
{
    static async Task<(bool success, int returnValue)> Taskmethod()
    {
        return (true, 34);
    }

    public static void Main()
    {
        Task<(bool success, int returnValue)> t1 = Taskmethod();
        Console.WriteLine(t1.Result.success);
        Console.WriteLine(t1.Result.returnValue);
    }
}

/*
Output:

    True
    34
*/
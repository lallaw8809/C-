using System;

public class Program
{
    delegate int FactDelegate(int num);

    public static void Main()
    {
        // Statement lamda (n: input parameter and f is the return value)
        FactDelegate fact = n =>{
                                    int f = 1;
                                    for (int i=1; i<n; i++)
                                    {
                                        f = f*i;
                                    }
                                    return f;
                                };

        Console.WriteLine("The factorial of 3 is " + fact(3));
    }
}

/*
Output:

The factorial of 3 is 2
*/
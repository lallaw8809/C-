using System;
using System.Threading;

namespace Program
{
    class Program
    {
        static void methodA()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I am in Running MethodA");
                Thread.Sleep(1000);
            }
        }
        static void methodB()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I am in Running MethodB");
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            // In Synchronous programming, methodA will mexecute first and method B will wait to complete the menthodA
            //methaodA();
            //methaodB();

            // We can run methodA and methodB parrally by using the thread programming
            Thread t1 = new Thread(new ThreadStart(methodA));
            t1.Start();
            methodB();
        }
    }
}


/*
Output:
-------
    I am in Running MethodB
    I am in Running MethodA
    I am in Running MethodA
    I am in Running MethodB
    I am in Running MethodA
    I am in Running MethodB
    I am in Running MethodB
    I am in Running MethodA
    I am in Running MethodA
    I am in Running MethodB
*/
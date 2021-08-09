using System;
using System.Threading.Tasks;

// Ref
// https://dotnetcodr.com/2014/01/01/5-ways-to-start-a-task-in-net-c/

namespace Program
{
    class Program
    {
        public static async Task TaskRunInDotNet4_5()
        {
            await Task.Run(() => AwaitAndAsync());
        }
        public static async Task<int> TaskAsynAwaitCallingMethod()
        {
            int res = await Task.FromResult<int>(GetSum(4, 5));
            return res;
        }

        private static int GetSum(int a, int b)
        {
            return a + b;
        }

        // Using Task.FromResult in .NET4.5 to return a result from a Task
        static void Main(string[] args)
        {
            // We can run methodA and methodB parrally by using task programming
            Task t1 = new Task(DefaultWayToRunTheTask);
            t1.Start();

            // DirectWayMethod to run the task
            Task.Factory.StartNew(() => { Console.WriteLine("Direct way to run the task"); });

            //Lambda and named method
            Task t2 = new Task(() => LamdaAndNamed());
            t2.Start();

            // Lambda and anonymous method
            Task t3 = Task.Run(() => 
            {
                LamdaAndAnonymousMethod();            
            });
                       
            // Using Auction 
            Task t4 = new Task(new Action(ActionMethod));
            t4.Start();

            // Using a delegate
            Task t5 = new Task(delegate { UsingDelegate(); });
            t5.Start();

            // Must to wait to complete the task
            t1.Wait();
            t2.Wait();
            t3.Wait();
            t4.Wait();
            t5.Wait();

            // Using Task.Run in .NET4.5
            TaskRunInDotNet4_5();

            // Using Task.FromResult in .NET4.5 to return a result from a Task
            Task<int> t = TaskAsynAwaitCallingMethod();
            Console.WriteLine(t.Result);
        }

        static void DefaultWayToRunTheTask()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Running the task deafult way");
                Task.Delay(1000);
            }
        }
        static void LamdaAndAnonymousMethod()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Running the task Lambda and anonymous way...");
                Task.Delay(1000);
            }
        }

        static void LamdaAndNamed()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Running the task Lambda and named way...");
                Task.Delay(1000);
            }
        }

        static void ActionMethod()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Running the task action method");
                Task.Delay(1000);
            }
        }
        static void UsingDelegate()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Running the task using a delegate method");
                Task.Delay(1000);
            }
        }
        static void AwaitAndAsync()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Running the task using a Async and Await ....");
                Task.Delay(1000);
            }
        }

    }
}


/*
Output:
-------
    Running the task deafult way
    Running the task Lambda and anonymous way...
    Running the task Lambda and named way...
    Direct way to run the task
    Running the task action method
    Running the task using a delegate method
    Running the task Lambda and anonymous way...
    Running the task Lambda and named way...
    Running the task Lambda and named way...
    Running the task deafult way
    Running the task using a delegate method
    Running the task Lambda and anonymous way...
    Running the task action method
    Running the task action method
    Running the task using a delegate method
    Running the task deafult way
    9
    Running the task using a Async and Await ....
    Running the task using a Async and Await ....
    Running the task using a Async and Await ....
*/
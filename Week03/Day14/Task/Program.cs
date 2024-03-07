using System.Diagnostics;
using System.Threading.Tasks;

class Program{
    static void Main(){
        Console.WriteLine($"Starting main program, thread id: {Thread.CurrentThread.ManagedThreadId}\n");
        Task task1 = Task.Run(Process1);
        Task task2 = Task.Run(() => Process2(10));

        //task with return
        Task<int> task3 = Task<int>.Run(() => ReturnInt(5));
        Console.WriteLine(task3.Result);
        
        // Task task1 = new(Process1);
        // Task task2 = new(() => Process2(10));

        // task1.Start();
        // task2.Start();

        Task.WaitAll(task1, task2, task3);
    }

    public static void Process1(){
        Stopwatch stopwatch1 = new();
        stopwatch1.Start();
        Console.WriteLine("Starting process 1, counting to 10..");
        Console.WriteLine($"Thread 1 id: {Thread.CurrentThread.ManagedThreadId}");
        for(int i=0; i<10; i++){
            Console.Write((i + 1) + ", ");
        }
        Console.WriteLine("");
        stopwatch1.Stop();
        Console.WriteLine($"Process 1 time: {stopwatch1.ElapsedMilliseconds} ms\n");
    }

    public static void Process2(int n){
        Stopwatch stopwatch2 = new();
        stopwatch2.Start();
        Console.WriteLine($"Starting process 2, counting down from {n}..");
        Console.WriteLine($"Thread 2 id: {Thread.CurrentThread.ManagedThreadId}");
        for(int i=0; i<n; i++){
            Console.Write(n-i + ", ");
        }
        Console.WriteLine("");
        stopwatch2.Stop();
        Console.WriteLine($"Process 2 time: {stopwatch2.ElapsedMilliseconds} ms\n");
    }

        public static int ReturnInt(int n){
            return n;
    }
}



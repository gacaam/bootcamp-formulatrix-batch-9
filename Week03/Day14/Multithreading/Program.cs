using System.Diagnostics;

class Program{
    static void Main(){
        Console.WriteLine($"Starting main program, thread id: {Thread.CurrentThread.ManagedThreadId}\n");
        Thread thread1 = new(Process1);
        Thread thread2 = new(() => Process2(10));

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Process3(10);
    }

    public static void Process1(){
        Stopwatch stopwatch1 = new();
        stopwatch1.Start();
        Console.WriteLine("Starting process 1, counting to 10..");
        Console.WriteLine($"Thread 1 id: {Thread.CurrentThread.ManagedThreadId}");
        for(int i=0; i<10; i++){
            Console.Write((i + 1) + ", ");
        }
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
        stopwatch2.Stop();
        Console.WriteLine($"Process 2 time: {stopwatch2.ElapsedMilliseconds} ms\n");
    }

    public static void Process3(int n){
        Stopwatch stopwatch3 = new();
        stopwatch3.Start();
        Console.WriteLine($"Starting process 3, counting up and down..");
        Console.WriteLine($"Thread 3 id: {Thread.CurrentThread.ManagedThreadId}");
        for(int i=0; i<n; i++){
            Console.Write((i + 1) + ", ");
        }
        for(int i=0; i<n; i++){
            Console.Write(n-i + ", ");
        }
        stopwatch3.Stop();
        Console.WriteLine($"Process 3 time: {stopwatch3.ElapsedMilliseconds} ms");
    }
}



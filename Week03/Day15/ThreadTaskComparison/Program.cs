using System.Diagnostics;

class Program {
    static async Task Main() {
        Stopwatch stopwatch = new();
        
        stopwatch.Start();
        ThreadExecution();
        stopwatch.Stop();
        Console.WriteLine("Thread : " + stopwatch.ElapsedTicks);

        stopwatch.Reset();
        stopwatch.Start();
        TaskExecution();
        stopwatch.Stop();
        Console.WriteLine("TASK : " + stopwatch.ElapsedTicks);

        stopwatch.Reset();
        stopwatch.Start();
        await TaskAsyncAwait();
        stopwatch.Stop();
        Console.WriteLine("Async : " + stopwatch.ElapsedTicks);

    }
    static void ThreadExecution() {
        Thread[] threads = new Thread[100];
        for(int i = 0; i < threads.Length; i++) {
            threads[i] = new Thread(() => Execution());
            threads[i].Start();
        }
        foreach(var i in threads) {
            i.Join();
        }
    }
    static void TaskExecution() {
        Task[] allTasks = new Task[100];
        for(int i = 0; i < allTasks.Length; i++) {
            allTasks[i] = new Task(() => Execution());
            allTasks[i].Start();
        }
        Task.WaitAll(allTasks);
    }
    static async Task TaskAsyncAwait() {
        Task[] allTasks = new Task[100];
        for(int i = 0; i < allTasks.Length; i++) {
            allTasks[i] = new Task(() => Execution());
            allTasks[i].Start();
        }
        await Task.WhenAll(allTasks);
    }
    static void Execution() {
        int iteration = 1000;
        for(int i = 0; i<iteration;i++) {

        }
    }
}
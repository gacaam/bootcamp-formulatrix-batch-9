using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program {
    static async Task Main() {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        await AwaitOrNot(true);
        // AwaitOrNot(false);
        stopwatch.Stop();
        Console.WriteLine("Time (ms): " + stopwatch.ElapsedMilliseconds);
    }

    static async Task AwaitOrNot(bool isAwait) {
        if(isAwait)
        {
            Console.WriteLine("AWAIT");
            await CallCallerOfCaller(true);
        }else{
            Console.WriteLine("NO AWAIT");
            CallCallerOfCaller(false);
        }
        
    }
    static async Task CallCallerOfCaller(bool isAwait) {
        Console.WriteLine("Calling caller of caller...");
        if(isAwait){
            await CallCaller(true);
        }else{
            CallCaller(false);
        }
    }
    static async Task CallCaller(bool isAwait) {
        Console.WriteLine("Calling caller...");
        if(isAwait){
            await CallExecution(true);
        }else{
            CallExecution(false);
        }
    }

    static async Task CallExecution(bool isAwait){
        Console.WriteLine("Calling execution...");
        if(isAwait){
            await Execution();
        }else{
            Execution();
        }
    }

    static async Task Execution(){
        Console.WriteLine("Executing process..");
        Task task1 = Task.Run(()=>Process(100));
        await Task.WhenAny(task1);
    }

    static void Process(int n){
        Console.WriteLine("\nActual execution :D");
        Console.WriteLine($"Counting to {n}\n");
        for(int i=0; i<n; i++){
            Console.Write((i + 1) + ", ");
        }
    }
}
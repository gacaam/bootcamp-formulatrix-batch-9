using System.Diagnostics.Metrics;

class Program{
    public static object obj = new();
    static int Counter = 0;
    static async Task Main(){
        Task task1 = Task.Run(async() => await Incrementer());
        Task task2 = Task.Run(async() => await Incrementer());
        await Task.WhenAll(task1, task2);
    }

    static async Task Incrementer(){
        for(int i=0; i<50; i++){
            // lock so only one thread runs the method at a time
            lock(obj){
                Counter++;
                Console.WriteLine(Counter);
            }
            await Task.Delay(50);
        }
    }
}
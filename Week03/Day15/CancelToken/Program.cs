class Program{
    static async Task Main(){
        CancellationTokenSource cts = new();
        CancellationToken token = cts.Token;

        Task task1 = Task.Run(() => DrawDot(token));
        await Task.Run(()=>CheckInput(cts));
        try{
            await task1;
        }catch(TaskCanceledException){
            Console.WriteLine("\nStopping program");
        }
    }

    static async Task DrawDot(CancellationToken token){
        int i,j;
        while(!token.IsCancellationRequested){
            for(i=0; i<=10; i++){
                for(j=0; j<=i; j++){
                    Console.Write(".");
                }    
                await Task.Delay(1000, token);
                Console.WriteLine("");                
            }
        }
    }

    static void CheckInput(CancellationTokenSource cts){
        if(Console.ReadKey().KeyChar == ' '){
            cts.Cancel();
        }
    }
}


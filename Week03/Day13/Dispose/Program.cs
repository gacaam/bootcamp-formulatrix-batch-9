using System.Diagnostics;

class Program{
    static void Main(){
        Stopwatch stopwatch = new();
        stopwatch.Start();

        //create objects
        File file = new();
        var files = file.generateObject(20_000, "a", "b");

        //delay for <ms> milliseconds
        int ms = 2000;
        Thread.Sleep(ms);

        //dispose objects in class file
        file.Dispose();
        stopwatch.Stop();
        Console.WriteLine($"Runtime: {stopwatch.ElapsedMilliseconds} ms");
        Console.ReadLine();
    }
}

class File : IDisposable
{
    public string? fileA;
    public string? fileB;
    public Tuple<string, string> generateObject(int iteration, string a, string b){
    for(int i=0; i<iteration; i++){
        fileA += a;
        fileB += b;
        }
    return new Tuple<string, string>(a,b);
    }
    private bool disposedValue;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                fileA = null;
                fileB = null;
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~FileManager()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
using System.Diagnostics;

class Program{
    static void Main(){
        string newString = "";
        int iteration = 100_000;
        int i;
        Stopwatch sw = new();
        sw.Start();
        for(i=0; i<iteration; i++){
            newString += "a";
            newString += "a";
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
        Console.ReadLine();
    }
}
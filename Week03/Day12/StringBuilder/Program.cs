using System.Diagnostics;
using System.Text;

class Program{
    static void Main(){
        StringBuilder newString = new("");
        int iteration = 1_000_000;
        int i;
        Stopwatch sw = new();
        sw.Start();
        for(i=0; i<iteration; i++){
            newString.Append("a");
            newString.Append("a");
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
        Console.ReadLine();
    }
}
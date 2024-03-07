using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Program{
    static void Main(){
        int intVal = ReturnAgain(4);
        int x = 0;

        Thread thread = new(() => x = ReturnAgain(10));
        thread.Start();
        thread.Join();
        Console.WriteLine(x);
    }

    public static int ReturnAgain(int n){
        return n;
    }
}
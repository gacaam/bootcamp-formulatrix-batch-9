using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

class Program
{
    static void Main()
    {
        FalseCalc calc = new();
        int result = calc.Pangkat(4,3); 
        //hasil kebalik
        //debug
    }
}

class FalseCalc{
    public int Pangkat(int x, int y)
    {
        //debug and trace
        Trace.WriteLine("Mulai Pemangkatan")
        int result = y;
        for (int i=1; i<x; i++)
        {
            result *= y;
        }
        Console.WriteLine($"{x}^{y}={result}");
        return result;
    }
}
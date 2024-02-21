using CalculatorOperator;

class Program{
    static void Main()
    {
        int a = 2;
        int b = 3;
        int addResult = CalculatorOperator.Operation.Add(a,b);
        Console.WriteLine($"{a} + {b} = " + addResult);
    }
}

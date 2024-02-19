// naming convention: class & method PascalCase, variable camelCase

class Program{
    static void Main()
    {
        Calculator calc = new Calculator();
        int additionResult = calc.Addition(2,5);
        int subtractionResult = calc.Subtraction(10,3);

        Console.WriteLine($"2 + 5 = {additionResult}");
        Console.WriteLine($"10 - 3 = {subtractionResult}");
    }
}
class Calculator{
    public int Addition(int number1, int number2)
    {
        return number1 + number2;
    }

    public int Subtraction(int number1, int number2)
    {
        return number1 - number2;
    }
}


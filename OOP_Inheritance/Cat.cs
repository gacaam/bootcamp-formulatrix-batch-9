namespace Animals;

public class Cat : Animal
{
    public Cat(string color, string gender): base(color, gender)
    {
        type = "Cat";
        Console.WriteLine(type + " Created (Child)");
    }
    public string name;
    public void Meow()
    {
        Console.WriteLine("Meow");
    }
}

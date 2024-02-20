namespace Animals;

public class Ant : Animal
{
    public Ant(string color, string gender) : base(color, gender)
    {
        type = "Ant";
        Console.WriteLine(type + " Created (Child)");
    }
}

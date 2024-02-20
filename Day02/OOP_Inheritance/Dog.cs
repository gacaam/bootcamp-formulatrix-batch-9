namespace Animals;

public class Dog : Animal
{
    public Dog(string color, string gender) : base(color, gender)
    {
        type = "Dog";
        Console.WriteLine(type + " Created (Child)");
    }
    public string name;
    public void Bark()
    {
        Console.WriteLine("Bark!");
    }
}

namespace Animals;

public class Animal
{
    public Animal(string color, string gender)
    {
        Console.WriteLine("New Animal Created (Parent)");
    
    }
    public string color;
    public string gender;
    public string type;
    public void Walk()
    {
        Console.WriteLine(type + " is walking");
    }
}

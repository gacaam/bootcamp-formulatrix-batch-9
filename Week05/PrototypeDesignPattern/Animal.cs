namespace PrototypeDesignPattern;

public class Animal : ICloneable
{
    public string? Color { get; set; }
    public double Height { get; set; }
    private int Weight { get; set; }
    public Animal()
    {

    }

    // clone by constructor
    public Animal(Animal animal)
    {
        this.Color = animal.Color;
        this.Height = animal.Height;
        this.Weight = animal.Weight;
    }

    public Animal(string color, double height, int weight)
    {
        Color = color;
        Height = height;
        Weight = weight;
    }

    // shallow copy
    public object Clone()
    {
        return MemberwiseClone();
    }
    public void DisplayAttributes()
    {
        Console.WriteLine($"Animal color: {Color}");
        Console.WriteLine($"Animal height: {Height}");
        Console.WriteLine($"Animal weight: {Weight}");
    }
}


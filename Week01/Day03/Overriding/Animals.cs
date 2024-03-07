namespace Overriding;

public class Animals
{
    public string gender;
    public string color;
    public string name;
    public virtual void MakeSound()
    {
        Console.WriteLine("*Animal Sound*");
    }
}

public class Cat : Animals
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Dog : Animals
{
    public override void MakeSound()
    {
       Console.WriteLine("Bark");
    }
}
public class Cow : Animals
{
    public new void MakeSound() //new utk menandakan method hiding
    {
       Console.WriteLine("Moooo");
    }
}


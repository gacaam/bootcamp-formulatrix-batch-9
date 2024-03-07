
public interface IAnimalFunc{
    public void MakeSound();
    public void Move();
}
public class Animal{
    public Animal(){
        Console.WriteLine("New animal");
    }
    public string name;
    public string gender;
    public string color;
}

public class Bird : Animal, ICommonFunction, IAnimalFunc{
    public void Breathe(){
        Console.WriteLine("...");
    }
    public void Reproduce(){
        Console.WriteLine("...");
    }
    public void Grow(){
        Console.WriteLine("...");
    }
    public void MakeSound(){
        Console.WriteLine("*chirp*");
    }
    public  void Move(){
        Console.WriteLine("fly");
    }
}

public class Cat : Animal, ICommonFunction, IAnimalFunc{
    public void Breathe(){
        Console.WriteLine("...");
    }
    public void Reproduce(){
        Console.WriteLine("...");
    }
    public void Grow(){
        Console.WriteLine("...");
    }
    public void MakeSound(){
        Console.WriteLine("meow..");
    }
    public  void Move(){
        Console.WriteLine("walk");
    }
}
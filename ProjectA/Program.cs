// top level 
// Console.WriteLine("Hello, World!");

class Program{ //acuan pertama program
    static void Main()
    {
        Person gracia = new Person();
        gracia.name = "Gracia";
        gracia.gender = "Female";
        gracia.age = 22;
        
        Console.WriteLine(gracia.name);
        Console.WriteLine(gracia.gender);
        Console.WriteLine(gracia.age);

        gracia.SayHi();
        gracia.Eat();
    }
}

class Person{
    public string name;
    public string gender;
    public int age;
    public void SayHi()
    {
        Console.WriteLine("Hi!");
    }
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

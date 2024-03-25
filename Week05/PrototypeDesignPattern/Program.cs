using PrototypeDesignPattern;

class Program{
    static void Main(){
        // Manual copying
        Animal animal1 = new("green", 1.2, 5);
        Animal animal2 = new()
        {
            Color = animal1.Color,
            Height = animal1.Height,
            // Weight = animal1.Weight
            // weight is inaccessible due to protection level
        };
        Console.WriteLine("Animal 1");
        animal1.DisplayAttributes();
        Console.WriteLine("\nAnimal 2 (manual copy from animal 1)");
        animal2.DisplayAttributes();

        // Prototype cloning
        Animal animal3 = new("red", 1.5, 3);
        Animal animal4 = (Animal) animal3.Clone();
        Animal animal5 = new(animal3);

        Console.WriteLine("\nAnimal 3");
        animal3.DisplayAttributes();
        Console.WriteLine("\nAnimal 4 (prototype clone from animal 3)");
        animal4.DisplayAttributes();
        Console.WriteLine("\nAnimal 5 (clone by constructor from animal 3)");
        animal4.DisplayAttributes();

        // Prototype registry
        AnimalCloneMachine cloneMachine = new();

        var animal6 = cloneMachine.CloneAnimal();
        var animal7 = cloneMachine.CloneAnimal();

        Console.WriteLine("\nAnimal 6 (clone from prototype registry)");
        animal6.DisplayAttributes();
        Console.WriteLine("\nAnimal 7 (clone from prototype registry)");
        animal7.DisplayAttributes();
    }
}
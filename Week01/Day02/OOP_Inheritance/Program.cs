using Animals;

class Program
{
    static void Main()
    {
        Cat cat = new("white", "female");
        Dog dog = new("brown", "male");
        Ant ant = new("black", "male");

        cat.Walk();
        dog.Bark();
    }
}

namespace PrototypeDesignPattern;

public class AnimalCloneMachine
{
    private Animal _templateAnimal;
    public AnimalCloneMachine()
    {
        _templateAnimal = new("Brown", 1.5, 3);
    }
    public Animal CloneAnimal()
    {
        return (Animal) _templateAnimal.Clone();
    }
}


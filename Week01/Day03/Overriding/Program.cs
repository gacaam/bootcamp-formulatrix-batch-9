using Overriding;

class Program
{
    static void Main()
    {
        Animals animal = new(); //parent method
        Cat cat = new();
        Animals animal_cat = new Cat(); //override w child method
        Dog dog = new();
        Animals animal_dog = new Dog(); //override w child method
        Cow cow = new();
        Animals animal_cow = new Cow(); //method hiding (still parent method)

        animal.MakeSound();
        cat.MakeSound();
        animal_cat.MakeSound();
        dog.MakeSound();
        animal_dog.MakeSound();
        cow.MakeSound();
        animal_cow.MakeSound();
        
    }
}
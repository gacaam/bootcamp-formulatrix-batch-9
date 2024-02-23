// simulation game
// sim with energy, mood, and hunger bar 
public delegate void MyDelegate();
class Program{
    static void Main(){
        Sim sim1 = new();
        sim1.EatMagicCookie();
    }
}
public class Sim{
    public string name;
    public string gender;
    public int age;
    public Sim(){
        name = "";
        gender = "unspecified";
        age = 0;
    }
    public void EatMagicCookie(){
        Console.WriteLine("Eating 1 magical cookie....");
        MyDelegate delegates = energy.RestoreEnergy;
        delegates += mood.RestoreMood;
        delegates += hunger.RestoreHunger;
        delegates.Invoke();
        Console.WriteLine("All bars restored");
    }
    Energy energy = new();
    Mood mood = new();
    Hunger hunger = new();
}
public class Energy{
    public int energyLevel;
    public void RestoreEnergy(){
        Console.WriteLine("Energy bar full");
    }
}
public class Mood{
    public int moodLevel;
    public void RestoreMood(){
        Console.WriteLine("Mood bar full");
    }
}
public class Hunger{
    public int hungerLevel;
    public void RestoreHunger(){
        Console.WriteLine("Hunger bar full");
    }
}
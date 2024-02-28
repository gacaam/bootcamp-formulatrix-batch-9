// simulation game
// sim with energy, mood, and hunger bar 
class Program{
    static void Main(){
        Sim sim1 = new();
        sim1.EatMagicCookie();
		Console.WriteLine($"Energy Level: {sim1.sim_energy}");

		// Sim sim2 = new();
		// sim2.Eat();
		// Console.WriteLine($"Hunger Level: {sim2.sim_hunger}");
		
    }
}
public class Sim{
    public event Func<int> myFunc;
    public string name;
    public string gender;
    public int age;
	public int sim_energy;
	public int sim_mood;
	public int sim_hunger;
    public Sim(){
        name = "";
        gender = "unspecified";
        age = 0;
    }
    public void EatMagicCookie(){
        Console.WriteLine("Eating 1 magical cookie....");
        
        myFunc += energy.RestoreEnergy;
        myFunc += mood.RestoreMood;
        myFunc += hunger.RestoreHunger;
        myFunc.Invoke();

		sim_energy = energy.energyLevel;
        sim_mood = mood.moodLevel;
        sim_hunger = hunger.hungerLevel;
        Console.WriteLine("All bars restored");
    }


    Energy energy = new();
    Mood mood = new();
    Hunger hunger = new();
}

public class Energy{
    public int energyLevel = 0;
    public int RestoreEnergy(){
		energyLevel = 100;
        Console.WriteLine("Energy bar full");
		return energyLevel;
	}
	public int Sleep(){
		Console.WriteLine("Sleeping..");
		energyLevel += 5;
		return energyLevel;
	
    }
}
public class Mood{
    public int moodLevel = 0;
    public int RestoreMood(){
		moodLevel = 100;
        Console.WriteLine("Mood bar full");
		return moodLevel;
    }
	public int DoHobby(){
		Console.WriteLine("Doing hobby..");
		moodLevel += 5;
		return moodLevel;
	}
}public class Energy{
    public int energyLevel = 0;
    public int RestoreEnergy(){
		energyLevel = 100;
        Console.WriteLine("Energy bar full");
		return energyLevel;
	}
	public int Sleep(){
		Console.WriteLine("Sleeping..");
		energyLevel += 5;
		return energyLevel;
	
    }
}
public class Hunger{
    public int hungerLevel = 0;
    public int RestoreHunger(){
		hungerLevel = 100;
        Console.WriteLine("Hunger bar full");
		return hungerLevel;
    }
	public int Eat(){
		Console.WriteLine("Eating..");
		hungerLevel += 5;
		return hungerLevel;
	}
}
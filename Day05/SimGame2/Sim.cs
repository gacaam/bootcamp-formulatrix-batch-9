public class Sim{
    public event Func<int> myFunc;
    public string name;
    public string gender;
    public int age;
	public int simEnergy;
	public int simMood;
	public int simHunger;
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

		simEnergy = energy.energyLevel;
        simMood = mood.moodLevel;
        simHunger = hunger.hungerLevel;
        Console.WriteLine("All bars restored");
    }
    public Energy energy = new();
    public Mood mood = new();
    public Hunger hunger = new();
}
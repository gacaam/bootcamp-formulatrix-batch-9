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
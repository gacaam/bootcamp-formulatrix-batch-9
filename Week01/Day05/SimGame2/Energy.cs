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
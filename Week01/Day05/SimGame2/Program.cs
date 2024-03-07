// simulation game
// sim with energy, mood, and hunger bar 
class Program{
    static void Main(){
        // Sim sim1 = new();
        // sim1.EatMagicCookie();
		// Console.WriteLine($"Energy Level: {sim1.simEnergy}");

		Sim sim2 = new();
		sim2.hunger.Eat();
		Console.WriteLine($"Hunger Level: {sim2.simHunger}");
		
    }
}
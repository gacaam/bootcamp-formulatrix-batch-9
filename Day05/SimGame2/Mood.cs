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
}
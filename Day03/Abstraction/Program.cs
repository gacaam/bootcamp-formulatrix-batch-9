
class CardController{
    public Card[] cards;
    public int count = 0;
    public CardController(int card){
        cards = new Card[card];
    }
    public bool AddCard(Card card){
		if(count == cards.Length-1) 
		{
			return false;
		}
		cards[count] = card;
		count++;
		return true;
    
}
public abstract class Card{
    private string name;
    private string color;
    public Card(string name_, string color_){
        name = name_;
        color = color_;
    }
    public abstract void StartFunction();
}

class JailCard : Card{
    public JailCard(string name, string color) : base(name, color){
    }
    public override void StartFunction()
    {
        Console.WriteLine("Go to jail!");
    }
}

class FreeParkCard : Card{
    public FreeParkCard(string name, string color) : base(name, color){
    }
    public override void StartFunction()
    {
        Console.WriteLine("Park anywhere as you wish.");
    }
}
}



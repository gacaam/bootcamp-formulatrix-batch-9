
class CardController{
    private Card[] _cards;
    private int _count = 0;
    public CardController(int card){
        _cards = new Card[card];
    }
    public bool AddCard(Card card){
		if(_count == _cards.Length-1) 
		{
			return false;
		}
		_cards[_count] = card;
		_count++;
		return true;
    
}
abstract class Card{
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



namespace JSONSerialize;
using System.Text.Json;

class Program{
    static void Main(){
        // Create instances & serializes into JSON
        Card card1 = new(CardColor.Red, CardValue.Zero);
        Card card2 = new(CardColor.Yellow, CardValue.One);
        Card card3 = new(CardColor.Green, CardValue.Two);

        Card[] cards = new Card[]{card1, card2, card3};

        using(StreamWriter sw = new("cards.json")){
            sw.Write(JsonSerializer.Serialize(cards));
        }
    }
}

public class Card{
    public CardColor Color{get; set;}
    public CardValue Value{get; set;}
    public Card(CardColor color, CardValue value){
        Color = color;
        Value = value;
    }
}

public enum CardValue{
    Zero,
    One,
    Two,
    Three,
    Four,
    Five
}

public enum CardColor{
    Red,
    Yellow,
    Green,
    Blue
}
using System.Text.Json;
using JSONSerialize;

class Program{
    static void Main(){
        string cardsDeserialized;
        using(StreamReader sr = new("../JSONSerializer/cards.json")){
            cardsDeserialized = sr.ReadToEnd(); 
        }
        Card[] cards = JsonSerializer.Deserialize<Card[]>(cardsDeserialized);
        foreach(Card card in cards){
            Console.WriteLine($"Card color: {card.Color}");
            Console.WriteLine($"Card value: {card.Value}");
            Console.WriteLine("");
        }

    }
}
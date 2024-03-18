using GameControllerLib;
using log4net;
using log4net.Config;

class Program
{
    static void Main()
    {
        XmlConfigurator.Configure(new FileInfo("./log4net.config"));
        Board board = new(8);
        Player playerInGame = new("Player1"); 
        Player playerNotPlaying = new("NotPlaying");

        Card card1 = new(1, "card 1");
        Card card2 = new(2, "card 2");

        GameController gameController = new(playerInGame, board);

        // Add cards
        gameController.AddCards(playerInGame, card1);
        gameController.AddCards(playerNotPlaying, card2);

        // Get players' cards
        gameController.GetCards(playerInGame);
        gameController.GetCards(playerNotPlaying);

        // Remove card
        gameController.RemoveCard(playerNotPlaying, card1);
        gameController.RemoveCard(playerInGame, card2);
        gameController.RemoveCard(playerInGame, card1);

        // Change card status
        gameController.ChangeCardStatus(card1, CardStatus.Removed);
    }
}
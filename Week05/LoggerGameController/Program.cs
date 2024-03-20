using GameControllerLib;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
// using log4net;
// using log4net.Config;
// using NLog;

class Program
{
    // public static Logger logger = LogManager.GetCurrentClassLogger();
    static void Main()
    {
        ILoggerFactory loggerFactory = LoggerFactory.Create(log =>
        {
            log.AddNLog("nlog.config");
        }

        );
        // XmlConfigurator.Configure(new FileInfo("./log4net.config"));
        
        ILogger<GameController> logger = loggerFactory.CreateLogger<GameController>();

        Board board = new(8);
        Player playerInGame = new("Player1"); 
        Player playerNotPlaying = new("NotPlaying");

        Card card1 = new(1, "card 1");
        Card card2 = new(2, "card 2");

        GameController gameController = new(playerInGame, board, logger);

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
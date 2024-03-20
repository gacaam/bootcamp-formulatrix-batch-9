namespace GameControllerLib;
using Microsoft.Extensions.Logging;
// using log4net;
// using log4net.Config;
// using NLog;

public class GameController
{
	private Dictionary<IPlayer, HashSet<ICard>> _players;
	private IBoard _board;
	public event Action<ICard>? OnCardUpdate;
	// private static readonly ILog logger = LogManager.GetLogger(typeof(GameController));
	// public static Logger logger = LogManager.GetCurrentClassLogger();
	private ILogger<GameController>? _log;

	public GameController(IPlayer player, IBoard board, ILogger<GameController>? logger = null)
	{
		_players = new()
			{
				{ player, new HashSet<ICard>()}
			};
		_board = board;
		_log = logger;
		_log?.LogInformation("GameController created");
	}

	public bool AddCards(IPlayer player, params ICard[] cards)
	{
	
		if (!_players.TryGetValue(player, out HashSet<ICard>? playerCards))
		{
			_log?.LogWarning($"(AddCards): player {player.GetName()} not in active players");
			return false;
		}
		foreach (var card in cards)
		{
			playerCards.Add(card);
			ChangeCardStatus(card, CardStatus.OnPlayer);
		}
		_log?.LogInformation($"Added cards to {player.GetName()}");
		return true;
	}

	public IEnumerable<ICard> GetCards(IPlayer player)
	{
		if (!_players.ContainsKey(player))
		{
			_log?.LogWarning($"(GetCards): Player {player.GetName()} doesn't exist in game controller, returning Enumerable.Empty<ICard>");
			return Enumerable.Empty<ICard>();
		}

		return _players[player];
	}

	public bool RemoveCard(IPlayer player, ICard card)
	{
		if (!_players.ContainsKey(player))
		{
			_log?.LogWarning($"(RemoveCard): player {player.GetName()} not in active players");
			return false;
		}

		if (!_players[player].Contains(card))
		{
			_log?.LogWarning($"(RemoveCard): Card doesn't exist in _players");
			return false;
		}
		_players[player].Remove(card);
		ChangeCardStatus(card, CardStatus.Removed);
		_log?.LogInformation($"Removed {card} from {player.GetName()}");
		return true;
	}

	public void ChangeCardStatus(ICard card, CardStatus status)
	{
		card.SetStatus(status);
		OnCardUpdate?.Invoke(card);
		// logger.Info($"Changed {card} status to {status}");
	}
}

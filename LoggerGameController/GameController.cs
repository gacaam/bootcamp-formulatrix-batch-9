namespace GameControllerLib;
using log4net;
using log4net.Config;

public class GameController
{
	private Dictionary<IPlayer, HashSet<ICard>> _players;
	private IBoard _board;
	public event Action<ICard>? OnCardUpdate;
	private static readonly ILog log = LogManager.GetLogger(typeof(GameController));

	public GameController(IPlayer player, IBoard board)
	{
		_players = new()
			{
				{ player, new HashSet<ICard>()}
			};
		_board = board;
		log.Info("GameController created");
	}

	public bool AddCards(IPlayer player, params ICard[] cards)
	{
	
		if (!_players.TryGetValue(player, out HashSet<ICard>? playerCards))
		{
			log.Warn($"Warning in AddCards: player {player.GetName()} not in active players");
			return false;
		}
		foreach (var card in cards)
		{
			playerCards.Add(card);
			ChangeCardStatus(card, CardStatus.OnPlayer);
		}
		log.Info($"Added cards to {player.GetName()}");
		return true;
	}

	public IEnumerable<ICard> GetCards(IPlayer player)
	{
		if (!_players.ContainsKey(player))
		{
			log.Warn($"Player {player.GetName()} doesn't exist in game, returning Enumerable.Empty<ICard>");
			return Enumerable.Empty<ICard>();
		}

		return _players[player];
	}

	public bool RemoveCard(IPlayer player, ICard card)
	{
		if (!_players.ContainsKey(player))
		{
			log.Warn($"Warning in RemoveCard: player {player.GetName()} not in active players");
			return false;
		}

		if (!_players[player].Contains(card))
		{
			log.Warn($"Warning in RemoveCard: Card doesn't exist in _players");
			return false;
		}
		_players[player].Remove(card);
		ChangeCardStatus(card, CardStatus.Removed);
		log.Info($"Successfully removed {card} from {player.GetName()}");
		return true;
	}

	public void ChangeCardStatus(ICard card, CardStatus status)
	{
		card.SetStatus(status);
		OnCardUpdate?.Invoke(card);
		// log.Info($"Changed {card} status to {status}");
	}
}

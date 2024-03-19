using GameControllerLib;
using Moq;
namespace GameControllerTest;

public class GameControllerTest
{
    private GameController _game;
    private Mock<IPlayer> _player;
    private Mock<IBoard> _board;
    private Mock<ICard> _card;

    [SetUp]
    public void Setup()
    {
        _player = new();
        _board = new();
        _card = new();
        _game = new(_player.Object, _board.Object);
        _game.AddCards(_player.Object, _card.Object);
    }

    [Test]
    public void RemoveCard_CardRemoved_CardExist()
    {
        bool actual = _game.RemoveCard(_player.Object, _card.Object);
        Assert.IsTrue(actual);
    }
}
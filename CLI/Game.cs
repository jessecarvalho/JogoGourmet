using Core.Interfaces;
using Core.Models;
using Core.Services;

namespace Core.ConsoleApp;

public class Game : IGame
{
    
    private readonly GameService _gameService;

    public Game(GameService gameService)
    {
        _gameService = gameService;
    }
    
    public void Start()
    {
        var node = _gameService.AddInitialFoodsAndCharacteristics();
        var playAgain = true;

        while (playAgain)
        {
            _gameService.ResetGuessedState(node);
            var guessedRight = false;
            var endSearch = false;
            var lastGuessedNode = node;
            _gameService.TryToGuess(node, ref guessedRight, ref endSearch, ref lastGuessedNode);

            if (!guessedRight)
            {
                _gameService.AddNewFoodNode(lastGuessedNode);
            }

            Console.WriteLine("Deseja jogar novamente? (S/N)");
            
            playAgain = _gameService.ReadBool();
        }
    }

}
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
            ResetGuessedState(node);
            var guessedRight = false;
            var endSearch = false;
            var lastGuessedNode = node;
            TryToGuess(node, ref guessedRight, ref endSearch, ref lastGuessedNode);

            if (!guessedRight)
            {
                AddNewFoodNode(lastGuessedNode);
            }

            Console.WriteLine("Deseja jogar novamente? (S/N)");
            
            playAgain = _gameService.ReadBool();
        }
    }
    
    public void ResetGuessedState(FoodNode node)
    {
        if (node != null)
        {
            foreach (var childNode in node.Nodes)
            {
                ResetGuessedState(childNode);
            }
        }
    }

    public void TryToGuess(FoodNode node, ref bool guessedRight, ref bool endSearch, ref FoodNode lastGuessedNode, bool exploreChild = false)
    {
        if (!guessedRight && !endSearch)
        {
            if (node.Name == "Initial Node")
            {
                foreach (var i in node.Nodes)
                {
                    TryToGuess(i, ref guessedRight, ref endSearch, ref lastGuessedNode, false);
                }
                return;
            }

            Console.WriteLine($"O prato que você pensou é {node.Name}? (S/N)");
            var answer = _gameService.ReadBool();

            if (answer == true)
            {
                lastGuessedNode = node;
                if (node.Nodes.Count > 0)
                {
                    foreach (var i in node.Nodes)
                    {
                        TryToGuess(i, ref guessedRight, ref endSearch, ref lastGuessedNode, true);
                    }
                    endSearch = true;
                }
                else
                {
                    GuessedRight();
                    guessedRight = true;
                }
            }
            else if (exploreChild)
            {
                foreach (var i in node.Nodes)
                {
                    TryToGuess(i, ref guessedRight, ref endSearch, ref lastGuessedNode, true);
                }
            }
        }
    }


    public void GuessedRight()
    {
        Console.WriteLine("Acertei de novo!");
    }

    public FoodNode AddNewFoodNode(FoodNode node)
    {
        Console.WriteLine("Qual prato você pensou?");
        var newFood = Console.ReadLine();
        var lastGuessedNodeName = node.Nodes.LastOrDefault()?.Name;
        Console.WriteLine($"Complete: {newFood} é ______ mas {lastGuessedNodeName} não.");
        var newCharacteristic = Console.ReadLine();
        return _gameService.AddNewFoodNode(node, newFood, newCharacteristic);
    }

}
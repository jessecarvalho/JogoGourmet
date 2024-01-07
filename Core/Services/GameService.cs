using Core.Interfaces;
using Core.Models;

namespace Core.Services;

public class GameService : IGameService
{
    private readonly IUserInteraction _userInteraction;
    public GameService(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
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
            _userInteraction.GuessPrompt(node.Name);
            var answer = ReadBool();

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
    public void GuessedRight()
    {
        _userInteraction.WinPrompt();
    }

    public FoodNode AddNewFoodNode(FoodNode node)
    {
        _userInteraction.AskForNewFood();
        var newFood = _userInteraction.ReadLine();
        var lastGuessedNodeName = node.Nodes.LastOrDefault()?.Name;
        _userInteraction.AskForNewCharacteristic(newFood, lastGuessedNodeName);
        var newCharacteristic = _userInteraction.ReadLine();
        return AddNewFoodNode(node, newFood, newCharacteristic);
    }

    public FoodNode AddNewFoodNode(FoodNode node, string newFood, string newCharacteristic)
    {
        var newFoodNode = new FoodNode(newFood);
        var newCharacteristicNode = new FoodNode(newCharacteristic);
        newCharacteristicNode.AddNode(newFoodNode);
        node.AddNode(newCharacteristicNode);
        return newCharacteristicNode;
    }

    public FoodNode AddInitialFoodsAndCharacteristics()
    {
        var initialNode = new FoodNode("Initial Node");
        var pasta = new FoodNode("Massa");
        pasta.AddNode(new FoodNode("Lasanha"));
        initialNode.AddNode(pasta);
        var chocolateCake = new FoodNode("Bolo de Chocolate");
        initialNode.AddNode(chocolateCake);
        return initialNode;
    }

    public bool ReadBool()
    {
        var answer = _userInteraction.ReadLine();
        
        while (answer?.ToUpper() != "S" && answer?.ToUpper() != "N")
        {
            _userInteraction.InvalidAnswer();
            answer = _userInteraction.ReadLine();
        }
        
        switch (answer?.ToUpper())
        {
            case "S":
                return true;
            case "N":
                return false;
            default:
                return false;
        }
        
    }
    
    

}
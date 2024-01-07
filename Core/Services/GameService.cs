using Core.Interfaces;
using Core.Models;

namespace Core.Services;

public class GameService : IGameService
{

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
        var answer = Console.ReadLine();
        
        while (answer?.ToUpper() != "S" && answer?.ToUpper() != "N")
        {
            Console.WriteLine("Resposta inválida. Digite S ou N.");
            answer = Console.ReadLine();
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
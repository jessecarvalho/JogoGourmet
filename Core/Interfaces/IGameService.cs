using Core.Models;

namespace Core.Interfaces;

public interface IGameService
{
    public void ResetGuessedState(FoodNode node);
    public void TryToGuess(FoodNode node, ref bool guessedRight, ref bool endSearch, ref FoodNode lastGuessedNode, bool exploreChild = false);
    public void GuessedRight();
    public FoodNode AddNewFoodNode(FoodNode node);
    public FoodNode AddNewFoodNode(FoodNode node, string newFood, string newCharacteristic);
    public FoodNode AddInitialFoodsAndCharacteristics();
    public bool ReadBool();

}
using Core.Models;

namespace Core.Interfaces;

public interface IGame
{
    public void Start();
    public void ResetGuessedState(FoodNode node);

    public void TryToGuess(FoodNode node, ref bool guessedRight, ref bool endSearch, ref FoodNode lastGuessedNode,
        bool exploreChild = false);
    public void GuessedRight();
    public FoodNode AddNewFoodNode(FoodNode node);
}
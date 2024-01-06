using Core.Models;

namespace Core.Interfaces;

public interface IGame
{
    public void Start();
    public void AddInitialFoodsAndCharacteristics();
    public void TryToGuess();
    public void GuessedRight();
    public FoodNode AddNewFood();
    public FoodNode AddNewCharacteristic();
    public void AddNewFoodToNewCharacteristic();
}
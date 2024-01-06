using Core.Models;

namespace Core.Interfaces;

public interface IGame
{
    public void Start();
    public void TryToGuess();
    public void GuessedRight();
    public Food AddNewFood();
    public Characteristic AddNewCharacteristic();
    public void AddNewFoodToNewCharacteristic();
}
namespace DefaultNamespace;

public interface IGame
{
    public void Start();
    public void TryToGuess();
    public void GuessedRight();
    public void AddNewFood();
    public void AddNewCharacteristic();
    public void AddNewFoodToNewCharacteristic();
}
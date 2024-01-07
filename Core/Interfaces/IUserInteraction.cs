namespace Core.Interfaces;

public interface IUserInteraction
{
    public void PlayAgainPrompt();
    public void GuessPrompt(string name);
    public void WinPrompt();
    public void AskForNewFood();
    public void AskForNewCharacteristic(string newFood, string lastGuessedNodeName);
    public void InvalidAnswer();
    public string ReadLine();
}
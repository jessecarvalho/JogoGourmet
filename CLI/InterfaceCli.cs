using Core.Interfaces;

namespace Core.ConsoleApp;

public class InterfaceCli: IUserInteraction
{
    public void PlayAgainPrompt()
    {
        Console.WriteLine("Deseja jogar novamente? (S/N)");
    }
    
    public void GuessPrompt(string name)
    {
        Console.WriteLine("O prato que você pensou é {0}? (S/N)", name);
    }
    
    public void WinPrompt()
    {
        Console.WriteLine("Acertei de novo!");
    }
    
    public void AskForNewFood()
    {
        Console.WriteLine("Qual prato você pensou?");
    }
    
    public void AskForNewCharacteristic(string newFood, string lastGuessedNodeName)
    {
        Console.WriteLine($"Complete: {newFood} é ______ mas {lastGuessedNodeName} não.?");
    }
    
    public void InvalidAnswer()
    {
        Console.WriteLine("Resposta inválida.");
    }
    
    public string ReadLine()
    {
        return Console.ReadLine();
    }
    
}
using Core.Models;
using Core.Services;

namespace Core.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameService = new GameService(); 
            var game = new Game(gameService); 
            game.Start();
        }
    }
}
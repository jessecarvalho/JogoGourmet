namespace Core.Models;


public class Food
{
    public string name { get; set; }
    public Characteristic? characteristic { get; set; }
    
    public Food(string name)
    {
        this.name = name;
    }
}
namespace Core.Models;


public class FoodNode
{
    public string Name { get; set; }
    public List<FoodNode>? Nodes { get; set; }

    public FoodNode(string name)
    {
        this.Name = name;
    }
}
namespace Core.Models;

public class Characteristic
{
    public string description { get; set; }
    public List<Food> relatedFoods { get; set; }
    public List<Characteristic> subCharacteristics { get; set; }
    
    public Characteristic AddSubCharacteristic(Characteristic subCharacteristic)
    {
        subCharacteristics.Add(subCharacteristic);
        return subCharacteristic;
    }
}
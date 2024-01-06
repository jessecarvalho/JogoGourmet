namespace DefaultNamespace;

public class Characteristic
{
    public string description { get; set; }
    public List<Food> relatedFoods { get; set; }
    public List<Characteristic> subCharacteristics { get; set; }
    
    public AddSubCharacteristic(Characteristic subCharacteristic)
    {
        subCharacteristics.Add(subCharacteristic);
    }
}
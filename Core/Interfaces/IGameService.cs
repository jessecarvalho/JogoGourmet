using Core.Models;

namespace Core.Interfaces;

public interface IGameService
{
    public FoodNode AddNewFoodNode(FoodNode node, string newFood, string newCharacteristic);
    public FoodNode AddInitialFoodsAndCharacteristics();
    public bool ReadBool();
}
using ZooERP.Domain.Interfaces;

namespace ZooERP.Domain.Animals
{
    public abstract class Animal : IAlive, IInventory
    {
        public string Name { get; }
        public int FoodPerDay { get; }
        public int InventoryNumber { get; }

        protected Animal(string name, int foodPerDay, int inventoryNumber)
        {
            Name = name;
            FoodPerDay = foodPerDay;
            InventoryNumber = inventoryNumber;
        }
    }
}

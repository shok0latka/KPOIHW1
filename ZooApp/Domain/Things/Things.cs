using ZooERP.Domain.Interfaces;

namespace ZooERP.Domain.Things
{
    public abstract class Thing : IInventory
    {
        public string Name { get; }
        public int InventoryNumber { get; }

        protected Thing(string name, int inventoryNumber)
        {
            Name = name;
            InventoryNumber = inventoryNumber;
        }
    }
    public class Table : Thing
    {
        public Table(int inventoryNumber) : base("Table", inventoryNumber) { }
    }

    public class Computer : Thing
    {
        public Computer(int inventoryNumber) : base("Computer", inventoryNumber) { }
    }
}

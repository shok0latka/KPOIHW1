namespace ZooERP.Domain.Animals
{
    public class Wolf : Predator
    {
        public Wolf(string name, int inventoryNumber)
            : base(name, 8, inventoryNumber) { }
    }
}
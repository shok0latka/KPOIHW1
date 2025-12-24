namespace ZooERP.Domain.Animals
{
    public class Tiger : Predator
    {
        public Tiger(string name, int inventoryNumber)
            : base(name, 10, inventoryNumber) { }
    }
}
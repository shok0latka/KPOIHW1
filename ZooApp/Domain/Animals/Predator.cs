namespace ZooERP.Domain.Animals
{
    public abstract class Predator : Animal
    {
        protected Predator(string name, int foodPerDay, int inventoryNumber)
            : base(name, foodPerDay, inventoryNumber)
        {
        }
    }
}

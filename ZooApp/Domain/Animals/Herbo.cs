namespace ZooERP.Domain.Animals
{
    public abstract class Herbo : Animal
    {
        public int KindnessLevel { get; }

        protected Herbo(string name, int foodPerDay, int inventoryNumber, int kindnessLevel)
            : base(name, foodPerDay, inventoryNumber)
        {
            KindnessLevel = kindnessLevel;
        }
    }
}

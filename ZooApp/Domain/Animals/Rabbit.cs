namespace ZooERP.Domain.Animals
{
    public class Rabbit : Herbo
    {
        public Rabbit(string name, int inventoryNumber, int kindnessLevel)
            : base(name, 2, inventoryNumber, kindnessLevel) { }
    }
}
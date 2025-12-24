using ZooERP.Domain.Animals;

namespace ZooERP.Application.Interfaces
{
    public interface IAnimalRepository
    {
        void Add(Animal animal);
        IReadOnlyCollection<Animal> GetAll();
    }
}

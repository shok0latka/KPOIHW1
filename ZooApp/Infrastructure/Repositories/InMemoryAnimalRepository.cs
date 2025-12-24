using ZooERP.Application.Interfaces;
using ZooERP.Domain.Animals;

namespace ZooERP.Infrastructure.Repositories
{
    public class InMemoryAnimalRepository : IAnimalRepository
    {
        private readonly List<Animal> _animals = new();

        public void Add(Animal animal) => _animals.Add(animal);

        public IReadOnlyCollection<Animal> GetAll() => _animals.AsReadOnly();
    }
}

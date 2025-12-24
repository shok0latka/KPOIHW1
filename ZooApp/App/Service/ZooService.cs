using ZooERP.Application.Interfaces;
using ZooERP.Domain.Animals;

namespace ZooERP.Application.Services
{
    public class ZooService
    {
        private readonly IVeterinaryClinic _veterinaryClinic;
        private readonly IAnimalRepository _repository;

        public ZooService(
            IVeterinaryClinic veterinaryClinic,
            IAnimalRepository repository)
        {
            _veterinaryClinic = veterinaryClinic;
            _repository = repository;
        }

        public bool TryAddAnimal(Animal animal)
        {
            if (!_veterinaryClinic.CheckHealth(animal))
                return false;

            _repository.Add(animal);
            return true;
        }

        public int GetTotalFoodPerDay()
        {
            return _repository.GetAll().Sum(a => a.FoodPerDay);
        }

        public IEnumerable<Herbo> GetContactZooAnimals()
        {
            return _repository.GetAll()
                .OfType<Herbo>()
                .Where(h => h.KindnessLevel > 5);
        }

        public IReadOnlyCollection<Animal> GetAllAnimals()
        {
            return _repository.GetAll();
        }
    }
}

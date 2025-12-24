using ZooERP.Application.Interfaces;
using ZooERP.Application.Services;
using ZooERP.Domain.Animals;
using Xunit;

public class ZooServiceTests
{
    private class FakeVet : IVeterinaryClinic
    {
        public bool CheckHealth(Animal animal) => true;
    }

    private class FakeRepo : IAnimalRepository
    {
        private readonly List<Animal> _animals = new();
        public void Add(Animal animal) => _animals.Add(animal);
        public IReadOnlyCollection<Animal> GetAll() => _animals;
    }

    [Fact]
    public void Calculates_Total_Food_Correctly()
    {
        var service = new ZooService(new FakeVet(), new FakeRepo());
        service.TryAddAnimal(new Rabbit("R", 1, 8));
        service.TryAddAnimal(new Tiger("T", 2));

        Assert.Equal(12, service.GetTotalFoodPerDay());
    }

    [Fact]
    public void Returns_Only_Kind_Animals_For_Contact_Zoo()
    {
        var service = new ZooService(new FakeVet(), new FakeRepo());
        service.TryAddAnimal(new Rabbit("Good", 1, 9));
        service.TryAddAnimal(new Rabbit("Bad", 2, 3));

        Assert.Single(service.GetContactZooAnimals());
    }
}

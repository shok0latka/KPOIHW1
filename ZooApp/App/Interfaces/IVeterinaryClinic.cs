using ZooERP.Domain.Animals;

namespace ZooERP.Application.Interfaces
{
    public interface IVeterinaryClinic
    {
        bool CheckHealth(Animal animal);
    }
}

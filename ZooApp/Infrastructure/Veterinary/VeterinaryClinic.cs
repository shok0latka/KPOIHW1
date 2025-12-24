using ZooERP.Application.Interfaces;
using ZooERP.Domain.Animals;

namespace ZooERP.Infrastructure.Veterinary
{
    public class VeterinaryClinic : IVeterinaryClinic
    {
        public bool CheckHealth(Animal animal)
        {
            return true;
        }
    }
}

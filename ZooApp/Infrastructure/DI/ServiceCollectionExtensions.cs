using Microsoft.Extensions.DependencyInjection;
using ZooERP.Application.Interfaces;
using ZooERP.Application.Services;
using ZooERP.Infrastructure.Repositories;
using ZooERP.Infrastructure.Veterinary;

namespace ZooERP.Infrastructure.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddZooServices(this IServiceCollection services)
        {
            services.AddSingleton<IAnimalRepository, InMemoryAnimalRepository>();
            services.AddSingleton<IVeterinaryClinic, VeterinaryClinic>();
            services.AddSingleton<ZooService>();

            return services;
        }
    }
}

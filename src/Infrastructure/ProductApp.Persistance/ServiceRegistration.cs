using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistance.Context;
using ProductApp.Persistance.Repositories;

namespace ProductApp.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceRegistration(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(option => option.UseInMemoryDatabase("memoryDb"));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();

        }
    }
}

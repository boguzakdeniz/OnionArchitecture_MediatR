using Microsoft.EntityFrameworkCore;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Common;
using ProductApp.Persistance.Context;

namespace ProductApp.Persistance.Repositories
{
    public class GenericRepository<T>(ApplicationDbContext dbContext) : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        public async Task<List<T>> GetAllAsync() => await dbContext.Set<T>().ToListAsync();

        public async Task<T> GetByIdAsync(Guid id) => await dbContext.Set<T>().FindAsync(id);

        public async Task<T> AddAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

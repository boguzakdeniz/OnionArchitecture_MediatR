using Microsoft.EntityFrameworkCore;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Common;
using ProductApp.Persistance.Context;

namespace ProductApp.Persistance.Repositories
{
    public class GenericRepository<T>(ApplicationDbContext dbContext) : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task<List<T>> GetAllAsync() => await Table.ToListAsync();

        public async Task<T> GetByIdAsync(Guid id) => await Table.FindAsync(id);

        public async Task<T> AddAsync(T entity)
        {
            await Table.AddAsync(entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }
    }
}

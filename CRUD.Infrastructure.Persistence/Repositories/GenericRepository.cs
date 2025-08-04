using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Domain.Common;
using CRUD.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<TKey, T>(AppDbContext context) : IGenericRepository<TKey, T> where T : class
    {
        public Task<bool> ActiveAsync(TKey key)
        {
           var existingEntity =  context.Set<T>().FindAsync(key);
           if(existingEntity.Result == null)
                return Task.FromResult(false);

            context.Entry<T>(existingEntity.Result).Property<bool>("IsActive").CurrentValue = true;
            return context.SaveChangesAsync().ContinueWith(t => true);
        }

        public async Task AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public virtual Task<bool> DeactiveAsync(TKey key)
        {
            var existingEntity = context.Set<T>().FindAsync(key);
            if (existingEntity.Result == null)
                return Task.FromResult(false);

            context.Entry<T>(existingEntity.Result).Property<bool>("IsActive").CurrentValue = false;
            return context.SaveChangesAsync().ContinueWith(t => true);
        }

        public async Task DeleteAsync(TKey key)
        {
            var entity = await context.Set<T>().FindAsync(key);
            if(entity != null)
            {
                context.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(TKey key)
        {
            var entity = await context.Set<T>().FindAsync(key);
            return entity != null;
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await context
                .Set<T>()
                .Where(e => EF.Property<bool>(e, "IsActive") == true)
                .ToListAsync();
        }

        public async Task<T> GetByIdAsync(TKey key)
        {
            return await context.Set<T>().FindAsync(key);
        }

        public async Task<bool> UpdateAsync(TKey key, T entity)
        {
            var existingEntity = await context.Set<T>().FindAsync(key);

            if (existingEntity is null)
                return false;

            context.Entry<T>(existingEntity).CurrentValues.SetValues(entity);
            await context.SaveChangesAsync();
            return true;
        }
    }
}

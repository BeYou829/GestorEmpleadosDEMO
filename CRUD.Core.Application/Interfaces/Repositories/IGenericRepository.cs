namespace CRUD.Core.Application.Interfaces.Repositories
{
    public interface IGenericRepository<TKey, T> where T : class
    {
        Task AddAsync(T entity);
        Task<bool> UpdateAsync(TKey key, T entity);
        Task DeleteAsync(TKey key);
        Task<T> GetByIdAsync(TKey key);
        Task<ICollection<T>> GetAllAsync();
        Task<bool> ExistsAsync(TKey key);
    } 

}

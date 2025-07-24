namespace CRUD.Core.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<bool> UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
        Task<bool> ExistsAsync(int id);
    } 

}

namespace CRUD.Core.Application.Interfaces.Services
{
    public interface IGenericService<TKey,TSaveEntityDTO, TEntityDTO, TEntity>
    {
        Task AddAsync(TSaveEntityDTO entity);
        Task<TEntityDTO> GetByIdAsync(TKey key);
        Task UpdateAsync(TKey key,TSaveEntityDTO entity);
        Task<ICollection<TEntityDTO>> GetAllAsync();
        Task DeleteAsync(TKey key);
        Task<bool> ExistsAsync(TKey key);
    }
}

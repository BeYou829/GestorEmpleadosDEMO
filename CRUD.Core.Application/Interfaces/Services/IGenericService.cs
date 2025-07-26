namespace CRUD.Core.Application.Interfaces.Services
{
    public interface IGenericService<TKey,TSaveEntityDTO, TEntityDTO, TEntity>
    {
        Task AddAsync(TSaveEntityDTO entity);
        Task<bool> UpdateAsync(TKey key,TSaveEntityDTO entity);
        Task DeleteAsync(TKey key);
        Task<TEntityDTO> GetByIdAsync(TKey key);
        Task<ICollection<TEntityDTO>> GetAllAsync();
        Task<bool> ExistsAsync(TKey key);
    }
}

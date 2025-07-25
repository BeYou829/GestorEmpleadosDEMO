﻿using CRUD.Core.Application.Interfaces.Repositories;
using CRUD.Core.Application.Interfaces.Services;
using Mapster;

namespace CRUD.Core.Application.Services
{
    public class GenericService<TKey, TSaveEntityDTO, TEntityDTO, TEntity>(IGenericRepository<TKey, TEntity> genericRepository)
        : IGenericService<TKey, TSaveEntityDTO, TEntityDTO, TEntity>
    where TEntity : class
    where TSaveEntityDTO : class
    where TEntityDTO : class
    {
        public async Task AddAsync(TSaveEntityDTO entity)
        {
            await genericRepository.AddAsync(entity.Adapt<TEntity>());
        }

        public async Task DeleteAsync(TKey key)
        {
            await genericRepository.DeleteAsync(key);
        }

        public Task<bool> ExistsAsync(TKey key)
        {
            return genericRepository.ExistsAsync(key);  
        }

        public async Task<ICollection<TEntityDTO>> GetAllAsync()
        {
            return await genericRepository.GetAllAsync()
                .ContinueWith(task => task.Result.Adapt<ICollection<TEntityDTO>>());
        }

        public async Task<TEntityDTO> GetByIdAsync(TKey key)
        {
            return await genericRepository.GetByIdAsync(key)
                .ContinueWith(task => task.Result.Adapt<TEntityDTO>());
        }

        public async Task UpdateAsync(TKey key,TSaveEntityDTO entity)
        {
            await genericRepository.UpdateAsync(key, entity.Adapt<TEntity>());
        }
    }
}

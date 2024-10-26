using System;
using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces;

public interface IGenericRepositorty<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(int id);
    Task<IReadOnlyList<T>> ListAllAsync();
    Task<T> GetEntityWithSpec(ISpecification<T> spec);
    Task<IReadOnlyList<T>> ListAllAsync(ISpecification<T> spec);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
    Task<bool> SaveAllAsync();
    bool Exist(int id);
    // Task ListAsync(ISpecification<T> spec);
}
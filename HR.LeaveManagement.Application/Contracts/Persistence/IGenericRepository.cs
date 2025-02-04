﻿namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<List<T>> GetAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<int> CreateAsync(T entity);
}

namespace HR.LeaveManagement.Application.Contracts.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync();
    Task<T> GetById(int id);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<T> CreateAsync(T entity);
}

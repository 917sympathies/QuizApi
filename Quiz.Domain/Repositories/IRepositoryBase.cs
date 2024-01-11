using System.Linq.Expressions;

namespace Quiz.Domain.Repositories;

public interface IRepositoryBase<T>
{
    Task CreateAsync(T entity);
    Task DeleteAsync(T entity);
    Task UpdateAsync(T entity);
    IQueryable<T> FindAll(bool trackChanges);
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
}
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Repositories;

namespace Quiz.Infrastructure.Persistence;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    private readonly DbContext _context;
    public RepositoryBase(DbContext context)
    {
        _context = context;
    }

    public Task CreateAsync(T entity) => Task.Run(() => _context.Set<T>().AddAsync(entity));

    public Task DeleteAsync(T entity) => Task.Run(() => _context.Set<T>().Remove(entity));

    public Task UpdateAsync(T entity) => Task.Run(() => _context.Set<T>().Update(entity));

    public IQueryable<T> FindAll(bool trackChanges) => !trackChanges
        ? _context.Set<T>()
            .AsNoTracking()
        : _context.Set<T>();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
        !trackChanges
            ? _context.Set<T>()
                .Where(expression)
                .AsNoTracking()
            : _context.Set<T>()
                .Where(expression);
}
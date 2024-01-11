using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;
using Quiz.Infrastructure.Persistence;

namespace Quiz.Infrastructure.Persistence;

public class UserRepository : RepositoryBase<User>, IUserRepository 
{
    public UserRepository(DbContext context) : base(context) {}

    public async Task CreateUser(User user) => await CreateAsync(user);

    public async Task DeleteUser(User user) => await DeleteAsync(user);

    public async Task UpdateUser(User user) => await UpdateAsync(user);

    public async Task<User?> GetUserByIdAsync(Guid id, bool trackChanges)
    {
        return await FindByCondition(u => u.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
    }

    public async Task<User?> GetUserByUsernameAsync(string username, bool trackChanges)
    {
        return await FindByCondition(u => u.Username.Equals(username), trackChanges).FirstOrDefaultAsync();
    }
}
using Microsoft.EntityFrameworkCore;
using Quiz.Application.DTO;
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;
using Quiz.Infrastructure.Models;
using Quiz.Infrastructure.Persistence;

namespace Quiz.Infrastructure.Persistence;

public class UserRepository : RepositoryBase<UserDto>, IUserRepository 
{
    public UserRepository(RepositoryContext context) : base(context) {}

    public async Task CreateUser(UserDto user) => await CreateAsync(user);

    public async Task DeleteUser(UserDto user) => await DeleteAsync(user);

    public async Task UpdateUser(UserDto user) => await UpdateAsync(user);

    public async Task<UserDto?> GetUserByIdAsync(Guid id, bool trackChanges)
    {
        return await FindByCondition(u => u.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
    }

    public async Task<UserDto?> GetUserByUsernameAsync(string username, bool trackChanges)
    {
        return await FindByCondition(u => u.Username.Equals(username), trackChanges).FirstOrDefaultAsync();
    }
}
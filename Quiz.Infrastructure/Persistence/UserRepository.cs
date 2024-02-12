using Microsoft.EntityFrameworkCore;
using Quiz.Application.Mapping;
using Quiz.Domain.DTO;
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;
using Quiz.Infrastructure.Models;
using Quiz.Infrastructure.Persistence;

namespace Quiz.Infrastructure.Persistence;

public class UserRepository : RepositoryBase<UserDtoToDb>, IUserRepository 
{
    public UserRepository(RepositoryContext context) : base(context) {}

    public async Task CreateUser(UserDtoToDb user) => await CreateAsync(user);

    public async Task DeleteUser(UserDtoToDb user) => await DeleteAsync(user);

    public async Task UpdateUser(UserDtoToDb user) => await UpdateAsync(user);

    public async Task<UserDtoToDb?> GetUserByIdAsync(Guid id, bool trackChanges) =>
         await FindByCondition(u => u.Id.Equals(id), trackChanges).FirstOrDefaultAsync();

    public async Task<UserDtoToDb?> GetUserByUsernameAsync(string username, bool trackChanges) =>
        await FindByCondition(u => u.Username.Equals(username), trackChanges).FirstOrDefaultAsync();

    public async Task<IEnumerable<UserDtoToDb>> GetUsersByUsernamesAsync(IEnumerable<string> usernames) =>  
        await FindByCondition(u => usernames.Contains(u.Username), false).ToListAsync();
}
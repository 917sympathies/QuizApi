using Quiz.Domain.DTO;
using Quiz.Domain.Entities;

namespace Quiz.Domain.Repositories;

public interface IUserRepository
{
    Task CreateUser(UserDtoToDb user);
    Task DeleteUser(UserDtoToDb user);
    Task UpdateUser(UserDtoToDb user);
    Task<UserDtoToDb?> GetUserByIdAsync(Guid id, bool trackChanges);
    Task<UserDtoToDb?> GetUserByUsernameAsync(string username, bool trackChanges);
    Task<IEnumerable<UserDtoToDb>> GetUsersByUsernamesAsync(IEnumerable<string> usernames);
}
using Quiz.Application.DTO;
using Quiz.Domain.Entities;

namespace Quiz.Domain.Repositories;

public interface IUserRepository
{
    Task CreateUser(UserDto user);
    Task DeleteUser(UserDto user);
    Task UpdateUser(UserDto user);
    Task<UserDto?> GetUserByIdAsync(Guid id, bool trackChanges);
    Task<UserDto?> GetUserByUsernameAsync(string username, bool trackChanges);
    // Task<ICollection<User>?> GetUsersByGameAsync(Game game, bool trackChanges);
}
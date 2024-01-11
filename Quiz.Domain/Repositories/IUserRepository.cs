using Quiz.Domain.Entities;

namespace Quiz.Domain.Repositories;

public interface IUserRepository
{
    Task CreateUser(User user);
    Task DeleteUser(User user);
    Task UpdateUser(User user);
    Task<User?> GetUserByIdAsync(Guid id, bool trackChanges);
    Task<User?> GetUserByUsernameAsync(string username, bool trackChanges);
    // Task<ICollection<User>?> GetUsersByGameAsync(Game game, bool trackChanges);
}
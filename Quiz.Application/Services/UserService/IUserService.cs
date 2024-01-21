using Quiz.Domain.Entities;

namespace Quiz.Application.Services.UserService;

public interface IUserService
{
    Task CreateAsync(User user);
    Task DeleteAsync(User user);
    Task UpdateAsync(User user);
    Task<User?> GetByIdAsync(Guid id);
    Task<User?> GetByUsernameAsync(string username);
}
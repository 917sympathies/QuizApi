using Quiz.Domain.DTO;
using Quiz.Domain.Entities;

namespace Quiz.Application.Services.UserService;

public interface IUserService
{
    Task CreateAsync(User user);
    Task DeleteAsync(User user);
    Task UpdateAsync(User user);
    Task<UserDtoToClient?> GetByIdAsync(Guid id);
    Task<UserDtoToClient?> GetByUsernameAsync(string username);
}
using Quiz.Application.Mapping;
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;

namespace Quiz.Application.Services.UserService;

public class UserService : IUserService
{
    private readonly IRepositoryManager _repositoryManager;
    public UserService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

    public Task CreateAsync(User user)
    {
        var userDto = user.ToDto();
        return _repositoryManager.Users.CreateUser(userDto);
    }

    public Task DeleteAsync(User user)
    {
        var userDto = user.ToDto();
        return _repositoryManager.Users.DeleteUser(userDto);
    }

    public Task UpdateAsync(User user)
    {
        var userDto = user.ToDto();
        return _repositoryManager.Users.UpdateUser(userDto);
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        var userDto = await _repositoryManager.Users.GetUserByIdAsync(id, false);
        return userDto?.ToUser();
    }

    public async Task<User?> GetByUsernameAsync(string username)
    {
        var userDto = await _repositoryManager.Users.GetUserByUsernameAsync(username, false);
        return userDto?.ToUser();
    }
}
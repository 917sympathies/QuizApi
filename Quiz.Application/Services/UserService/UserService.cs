﻿using Quiz.Application.Mapping;
using Quiz.Domain.DTO;
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
        var userDto = user.ToDtoDb();
        return _repositoryManager.Users.CreateUser(userDto);
    }

    public Task DeleteAsync(User user)
    {
        var userDto = user.ToDtoDb();
        return _repositoryManager.Users.DeleteUser(userDto);
    }

    public Task UpdateAsync(User user)
    {
        var userDto = user.ToDtoDb();
        return _repositoryManager.Users.UpdateUser(userDto);
    }

    public async Task<UserDtoToClient?> GetByIdAsync(Guid id)
    {
        var userDto = await _repositoryManager.Users.GetUserByIdAsync(id, false);
        return userDto?.ToClient();
    }

    public async Task<UserDtoToClient?> GetByUsernameAsync(string username)
    {
        var userDto = await _repositoryManager.Users.GetUserByUsernameAsync(username, false);
        return userDto?.ToClient();
    }
}
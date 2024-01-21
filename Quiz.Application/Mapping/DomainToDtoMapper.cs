using Quiz.Application.DTO;
using Quiz.Domain.Entities;

namespace Quiz.Application.Mapping;

public static class DomainToDtoMapper
{
    public static UserDto ToDto(this User user)
    {
        return new UserDto
        {
            Id = user.Id,
            Email = user.Email.Value,
            Friends = user.Friends.Select(u => u.ToDto()).ToArray(),
            Password = user.Password.Value,
            Username = user.Username.Value
        };
    }
}
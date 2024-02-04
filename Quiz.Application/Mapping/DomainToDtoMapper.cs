using Quiz.Domain.DTO;
using Quiz.Domain.Entities;

namespace Quiz.Application.Mapping;

public static class DomainToDtoMapper
{
    public static UserDtoToDb ToDtoDb(this User user)
    {
        return new UserDtoToDb
        {
            Id = user.Id,
            Email = user.Email.Value,
            Friends = user.Friends?.Select(u => u.ToDtoDb()).ToArray(),
            Password = user.Password.Value,
            Username = user.Username.Value
        };
    }

    public static UserDtoToClient ToDtoClient(this User user)
    {
        return new UserDtoToClient
        {
            Username = user.Username.Value,
            Friends = user.Friends?.Select(u => u.ToDtoClient()).ToArray()
        };
    }
}
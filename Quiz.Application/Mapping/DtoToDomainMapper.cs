using Quiz.Application.DTO;
using Quiz.Domain.Entities;
using Quiz.Domain.ValueObjects;

namespace Quiz.Application.Mapping;

public static class DtoToDomainMapper
{
    public static User ToUser(this UserDto userDto)
    {
        var user = User.Create(userDto.Id, 
            Username.Create(userDto.Username).Value, 
            Email.Create(userDto.Email).Value, 
            Password.From(userDto.Password).Value, 
            userDto.Friends.Select(u => u.ToUser()).ToArray());
        return user;
    }
}
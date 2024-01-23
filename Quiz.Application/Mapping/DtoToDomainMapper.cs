using Quiz.Domain.DTO;
using Quiz.Domain.Entities;
using Quiz.Domain.ValueObjects;

namespace Quiz.Application.Mapping;

public static class DtoToDomainMapper
{
    public static User ToUser(this UserDtoToDb userDtoToDb)
    {
        var user = User.Create(userDtoToDb.Id, 
            Username.Create(userDtoToDb.Username).Value, 
            Email.Create(userDtoToDb.Email).Value, 
            Password.From(userDtoToDb.Password).Value, 
            userDtoToDb.Friends?.Select(u => u.ToUser()).ToArray());
        return user;
    }
}
using Quiz.Domain.DTO;

namespace Quiz.Application.Mapping;

public static class DtoToDtoMapper
{
    public static UserDtoToClient ToClient(this UserDtoToDb user)
    {
        return new UserDtoToClient
        {
            Username = user.Username,
            Friends = user.Friends?.Select(u => u.ToClient()).ToArray()
        };
    }
}
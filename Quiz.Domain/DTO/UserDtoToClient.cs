namespace Quiz.Domain.DTO;

public class UserDtoToClient
{
    public string Username { get; init; } = default!;
    public ICollection<UserDtoToClient>? Friends { get; init; } = default!;
}
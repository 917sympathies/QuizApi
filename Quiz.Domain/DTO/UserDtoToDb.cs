namespace Quiz.Domain.DTO;

public class UserDtoToDb
{
    public Guid Id { get; init; } = default!;
    public string Username { get; init; } = default!;
    public string Email { get; init; } = default!;
    public string Password { get; init; } = default!;
    public ICollection<UserDtoToDb>? Friends { get; init; } = default!;
}
using Quiz.Domain.DTO;
using Quiz.Domain.Enumerations;

namespace Quiz.Domain.Entities;

public class Game
{
    public Guid Id { get; init; }
    public GameStatus Status { get; init; }
    public GameVisibility Visibility { get; init; }
    public ICollection<UserDtoToDb> Players { get; set; } = default!;
    public Guid QuestionPackId { get; init; }
    public ICollection<GameResult> Results { get; init; } = default!;
}
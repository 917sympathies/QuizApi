using Quiz.Application.DTO;
using Quiz.Domain.Enumerations;

namespace Quiz.Domain.Entities;

public class Game
{
    public Guid Id { get; init; }
    public GameStatus Status { get; init; }
    public GameVisibility Visibility { get; init; }
    public ICollection<UserDto> Players { get; init; } = new List<UserDto>();
    public QuestionPack QuestionPack { get; init; } = new QuestionPack();
    public ICollection<GameResult> Results { get; init; } = new List<GameResult>();
}
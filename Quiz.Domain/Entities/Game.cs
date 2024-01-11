using Quiz.Domain.Enumerations;

namespace Quiz.Domain.Entities;

public class Game
{
    public Guid Id { get; private set; }
    public GameStatus Status { get; set; }
    public GameVisibility Visibility { get; set; }
    public ICollection<User> Players = new List<User>();
    public QuestionPack QuestionPack = new QuestionPack();
    public ICollection<GameResult> Results = new List<GameResult>();
}
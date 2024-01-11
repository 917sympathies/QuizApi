namespace Quiz.Domain.Entities;

public class GameResult
{
    public Guid Id { get; private set; }
    public Guid PlayerId { get; set; }
    public int Points { get; set; }
}
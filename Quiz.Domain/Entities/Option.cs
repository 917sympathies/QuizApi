namespace Quiz.Domain.Entities;

public class Option
{
    public int Id { get; init; }
    public string Value { get; init; } = default!;
    public Guid QuestionId { get; init; }
}
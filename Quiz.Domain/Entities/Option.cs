namespace Quiz.Domain.Entities;

public class Option
{
    public Guid Id { get; init; }
    public string Value { get; init; } = default!;
    public Guid QuestionId { get; init; }
}
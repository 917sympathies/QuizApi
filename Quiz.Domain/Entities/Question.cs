namespace Quiz.Domain.Entities;

public class Question
{
    public Guid Id { get; private set; }
    public string Content { get; init; } = string.Empty;
    public string Answer { get; init; } = string.Empty; // изменить на тип Option, чтоб не было такой ситуации, что ответ не входил в Options
    public string Theme { get; init; } = string.Empty;
    public ICollection<Option> Options { get; init; } = new List<Option>();
    public int Value { get; init; } = default!;
    public Guid QuestionPackId { get; init; }
}
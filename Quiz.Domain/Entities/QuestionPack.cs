namespace Quiz.Domain.Entities;

public class QuestionPack
{
    public Guid Id { get; init; }
    public string Theme { get; init; } = string.Empty;
    public ICollection<Question> Questions { get; init; } = new List<Question>();
}
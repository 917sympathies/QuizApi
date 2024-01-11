namespace Quiz.Domain.Entities;

public class QuestionPack
{
    public Guid Id { get; private set; }
    public string Theme { get; set; } = string.Empty;
    public ICollection<Question> Questions = new List<Question>();
}
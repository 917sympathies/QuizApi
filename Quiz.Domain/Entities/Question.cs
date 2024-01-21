namespace Quiz.Domain.Entities;

public class Question
{
    public Guid Id { get; private set; }
    public string Content { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
    public string Theme { get; set; } = string.Empty;
    public ICollection<Option> Options { get; set; } = new List<Option>();
    public int Value { get; set; }
}
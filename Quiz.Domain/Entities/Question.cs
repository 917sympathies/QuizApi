namespace Quiz.Domain.Entities;

public class Question
{
    public Guid Id { get; private set; }
    public string Content { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
    public string Theme { get; set; } = string.Empty;
    public ICollection<string> Options { get; set; } = new List<string>();
    public int Value { get; set; }
}
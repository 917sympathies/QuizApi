namespace Quiz.Domain.Repositories;

public interface IRepositoryManager
{
    public IGameRepository Games { get; }
    public IQuestionRepository Questions { get; }
    public IQuestionPackRepository QuestionPacks { get; }
    public IUserRepository Users { get; }
    Task SaveAsync();
}
namespace Quiz.Domain.Repositories;

public interface IRepositoryManager
{
    IGameRepository Games { get; }
    IQuestionRepository Questions { get; }
    IQuestionPackRepository QuestionPacks { get; }
    IUserRepository Users { get; }
    Task SaveAsync();
}
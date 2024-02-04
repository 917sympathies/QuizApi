using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;

namespace Quiz.Application.Services.QuestionPackService;

public class QuestionPackService : IQuestionPackService
{
    private readonly IRepositoryManager _repositoryManager;
    public QuestionPackService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

    public async Task<QuestionPack?> GetQuestionPackByIdAsync(Guid id)
    {
        return await _repositoryManager.QuestionPacks.GetQuestionPackByIdAsync(id, false);
    }

    public async Task<ICollection<QuestionPack>> GetAllQuestionPacksAsync()
    {
        return await _repositoryManager.QuestionPacks.GetAllQuestionPacksAsync();
    }
}
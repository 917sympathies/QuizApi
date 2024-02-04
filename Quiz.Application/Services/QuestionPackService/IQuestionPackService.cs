using Quiz.Domain.Entities;

namespace Quiz.Application.Services.QuestionPackService;

public interface IQuestionPackService
{
    Task<QuestionPack?> GetQuestionPackByIdAsync(Guid id);
    Task<ICollection<QuestionPack>> GetAllQuestionPacksAsync();
}
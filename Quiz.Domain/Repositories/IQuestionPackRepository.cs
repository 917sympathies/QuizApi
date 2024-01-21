using Quiz.Domain.Entities;

namespace Quiz.Domain.Repositories;

public interface IQuestionPackRepository
{
    Task CreateQuestionPack(QuestionPack pack);
    Task DeleteQuestionPack(QuestionPack pack);
    Task UpdateQuestionPack(QuestionPack pack);
    Task<QuestionPack?> GetQuestionPackByIdAsync(Guid id, bool trackChanges);
    Task<ICollection<QuestionPack>> GetAllQuestionPacksAsync(); 
}
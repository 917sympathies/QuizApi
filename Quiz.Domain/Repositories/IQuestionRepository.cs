using Quiz.Domain.Entities;

namespace Quiz.Domain.Repositories;

public interface IQuestionRepository
{
    Task CreateQuestion(Question question);
    Task DeleteQuestion(Question question);
    Task UpdateQuestion(Question question);
}
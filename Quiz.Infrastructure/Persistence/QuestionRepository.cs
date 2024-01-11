using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;

namespace Quiz.Infrastructure.Persistence;

public class QuestionRepository : RepositoryBase<Question>, IQuestionRepository
{
    public QuestionRepository(DbContext context) : base(context)
    {
    }

    public Task CreateQuestion(Question question) => CreateAsync(question);

    public Task DeleteQuestion(Question question) => DeleteAsync(question);

    public Task UpdateQuestion(Question question) => UpdateAsync(question);
}
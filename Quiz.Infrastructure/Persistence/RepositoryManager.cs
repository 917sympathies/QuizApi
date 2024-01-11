using Microsoft.EntityFrameworkCore;
using Quiz.Infrastructure.Persistence;

namespace Quiz.Domain.Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly DbContext _context;

    public RepositoryManager(DbContext context)
    {
        _context = context;
    }

    public IGameRepository Games { get; }
    public IQuestionRepository Questions { get; }
    public IQuestionPackRepository QuestionPacks { get; }
    public IUserRepository Users { get; }
    public Task SaveAsync() => _context.SaveChangesAsync();
}
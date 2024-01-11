using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;

namespace Quiz.Infrastructure.Persistence;

public class QuestionPackRepository : RepositoryBase<QuestionPack> , IQuestionPackRepository
{
    public QuestionPackRepository(DbContext context) : base(context)
    {
    }

    public Task CreateQuestionPack(QuestionPack pack) => CreateAsync(pack);

    public Task DeleteQuestionPack(QuestionPack pack)=> DeleteAsync(pack);

    public Task UpdateQuestionPack(QuestionPack pack)=> UpdateAsync(pack);

    public async Task<QuestionPack?> GetQuestionPackByIdAsync(Guid id, bool trackChanges) => await FindByCondition(qp => qp.Id.Equals(id), trackChanges).FirstOrDefaultAsync();

    public async Task<ICollection<QuestionPack>> GetAllQuestionPacksAsync() => await FindAll(false).ToListAsync();
    
}
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;

namespace Quiz.Application.Services.GameService;

public interface IGameService
{
    Task CreateAsync(Game game);
    Task DeleteAsync(Game game);
    Task UpdateAsync(Game game);
    Task<Game?> GetByIdAsync(Guid id);
}
using Quiz.Domain.DTO;
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;

namespace Quiz.Application.Services.GameService;

public interface IGameService
{
    Task<Game?> CreateAsync(IEnumerable<string> usernames, Guid questionPackId);
    Task DeleteAsync(Game game);
    Task UpdateAsync(Game game);
    Task<Game?> GetByIdAsync(Guid id);
    Task<Game?> EndGame(Guid gameId, GameResultDto result);
}
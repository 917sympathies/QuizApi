using Quiz.Domain.Entities;

namespace Quiz.Domain.Repositories;

public interface IGameRepository
{
    Task CreateGame(Game game);
    Task DeleteGame(Game game);
    Task UpdateGame(Game game);
    Task<Game?> GetGameByIdAsync(Guid id, bool trackChanges);
}
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;

namespace Quiz.Application.Services.GameService;

public class GameService : IGameService
{
    private readonly IRepositoryManager _repositoryManager;
    public GameService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

    public Task CreateAsync(Game game)
    {
        return _repositoryManager.Games.CreateGame(game);
    }

    public Task DeleteAsync(Game game)
    {
        return _repositoryManager.Games.DeleteGame(game);
    }

    public Task UpdateAsync(Game game)
    {
        return _repositoryManager.Games.UpdateGame(game);
    }

    public Task<Game?> GetByIdAsync(Guid id)
    {
        return _repositoryManager.Games.GetGameByIdAsync(id, false);
    }
}
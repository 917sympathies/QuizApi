using Quiz.Domain.DTO;
using Quiz.Domain.Entities;
using Quiz.Domain.Enumerations;
using Quiz.Domain.Repositories;

namespace Quiz.Application.Services.GameService;

public class GameService : IGameService
{
    private readonly IRepositoryManager _repositoryManager;
    public GameService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

    public async Task<Game?> CreateAsync(IEnumerable<string> usernames, Guid questionPackId)
    {
        var players = new List<UserDtoToDb>(await _repositoryManager.Users.GetUsersByUsernamesAsync(usernames));
        if (players.Count == 0) return null;
        
        
        var questionPack = await _repositoryManager.QuestionPacks.GetQuestionPackByIdAsync(questionPackId, false);
        if (questionPack == null) return null;
        
        var game = new Game()
        {
            Status = GameStatus.Ongoing,
            Visibility = GameVisibility.Public,
            Players = players,
            QuestionPackId = questionPack.Id,
            Results = null
        };
        await _repositoryManager.Games.CreateGame(game);
        await _repositoryManager.SaveAsync();
        
        return game;
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

    public async Task<Game?> EndGame(Guid gameId, GameResultDto result)
    {
        var game = await _repositoryManager.Games.GetGameByIdAsync(gameId, false);
        if (game == null)
        {
            return null;
        }

        if (result.PlayersResults.Count == 0)
        {
            return null;
        }

        foreach (var res in result.PlayersResults)
        {
            var player = await _repositoryManager.Users.GetUserByUsernameAsync(res.Username, false);
            
            if (player == null) return null;
            
            game.Results.Add(new GameResult()
            {
                PlayerId = player.Id,
                Points = res.Points
            });
        }

        await _repositoryManager.SaveAsync();
        return game;
    }
}
using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Entities;
using Quiz.Infrastructure.Models;
using Quiz.Infrastructure.Persistence;

namespace Quiz.Domain.Repositories;

public class RepositoryManager : IRepositoryManager
{
    private RepositoryContext _context;

    private IUserRepository _userRepository;
    private IGameRepository _gameRepository;
    private IQuestionPackRepository _questionPackRepository;
    private IQuestionRepository _questionRepository;

    public RepositoryManager(RepositoryContext context)
    {
        _context = context;
    }

    public IGameRepository Games
    {
        get
        {
            if (_gameRepository == null) _gameRepository = new GameRepository(_context);
            return _gameRepository;
        }
    }

    public IQuestionRepository Questions
    {
        get
        {
            if (_questionRepository == null) _questionRepository = new QuestionRepository(_context);
            return _questionRepository;
        }
    }

    public IQuestionPackRepository QuestionPacks
    {
        get
        {
            if (_questionPackRepository == null) _questionPackRepository = new QuestionPackRepository(_context);
            return _questionPackRepository;
        }
    }

    public IUserRepository Users
    {
        get
        {
            if (_userRepository == null) _userRepository = new UserRepository(_context);
            return _userRepository;
        }
    }

    public Task SaveAsync() => _context.SaveChangesAsync();
}
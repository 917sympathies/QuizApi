using Microsoft.EntityFrameworkCore;
using Quiz.Application.DTO;
using Quiz.Domain.Entities;

namespace Quiz.Infrastructure.Models;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        :base(options)
    {
        
    }
    
    public DbSet<UserDto> Users { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionPack> QuestionPacks { get; set; }
}
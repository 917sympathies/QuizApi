using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Entities;

namespace Quiz.Infrastructure.Models;

public class RepositoryContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionPack> QuestionPacks { get; set; }
}
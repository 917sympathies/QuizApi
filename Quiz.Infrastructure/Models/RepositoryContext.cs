using Microsoft.EntityFrameworkCore;
using Quiz.Domain.DTO;
using Quiz.Domain.Entities;

namespace Quiz.Infrastructure.Models;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        :base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<QuestionPack>()
            .HasMany(qp => qp.Questions)
            .WithOne()
            .HasForeignKey(k => k.QuestionPackId);

        modelBuilder.Entity<Question>()
            .HasMany(q => q.Options)
            .WithOne()
            .HasForeignKey(k => k.QuestionId);

        modelBuilder.Entity<UserDtoToDb>()
            .HasMany(u => u.Friends)
            .WithMany();

        modelBuilder.Entity<Game>()
            .HasMany(g => g.Players)
            .WithMany();

        // modelBuilder.Entity<Question>()
        //     .HasOne(q => q.Answer)
        //     .WithOne()
        //     .HasForeignKey(k => k.)
    }

    public DbSet<UserDtoToDb> Users { get; init; }
    public DbSet<Game> Games { get; init; }
    public DbSet<Question> Questions { get; init; }
    public DbSet<QuestionPack> QuestionPacks { get; init; }
}
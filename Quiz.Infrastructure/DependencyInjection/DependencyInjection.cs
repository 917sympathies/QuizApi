using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quiz.Application.Services.GameService;
using Quiz.Application.Services.QuestionPackService;
using Quiz.Application.Services.UserService;
using Quiz.Domain.Entities;
using Quiz.Domain.Repositories;
using Quiz.Infrastructure.Models;
using Quiz.Infrastructure.Persistence;

namespace Quiz.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RepositoryContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("quizDbConnectionString"), b => b.MigrationsAssembly("Quiz.Api")));
        
        services.AddScoped<IRepositoryManager, RepositoryManager>();
        services.AddScoped<IQuestionPackService, QuestionPackService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IGameService, GameService>();
        return services;
    }
}
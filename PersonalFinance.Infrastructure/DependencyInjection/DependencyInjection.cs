using Microsoft.Extensions.DependencyInjection;
using PersonalFinance.Application.Interfaces;
using PersonalFinance.Infrastructure.Repositories;

namespace PersonalFinance.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddScoped<ITransactionRepository, TransactionRepository>();

        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<ICategoryRepository, CategoryRepository>();

        return services;
    }
}
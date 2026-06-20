using Microsoft.Extensions.DependencyInjection;
using PersonalFinance.Application.Interfaces;
using PersonalFinance.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using PersonalFinance.Infrastructure.Data;

namespace PersonalFinance.Infrastructure.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        "Server=DESKTOP-P6FRBTF,1433;Database=PersonalFinanceDb;Trusted_Connection=True;TrustServerCertificate=True;"));

        services.AddScoped<ITransactionRepository, TransactionRepository>();

        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<ICategoryRepository, CategoryRepository>();

        return services;
    }
}
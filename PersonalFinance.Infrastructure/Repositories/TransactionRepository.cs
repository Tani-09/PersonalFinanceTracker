using Microsoft.EntityFrameworkCore;
using PersonalFinance.Application.Interfaces;

using PersonalFinance.Domain.Entities;
using PersonalFinance.Infrastructure.Data;

namespace PersonalFinance.Infrastructure.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private readonly AppDbContext _context;

    public TransactionRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Transaction transaction)
    {
        await _context.Transactions.AddAsync(transaction);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Transaction>> GetByUserIdAsync(Guid userId)
    {
        return await _context.Transactions
            .Where(t => t.UserId == userId)
            .ToListAsync();
    }

    public async Task<List<Transaction>> GetByCategoryAsync(Guid categoryId)
    {
        return await _context.Transactions
            .Where(t => t.CategoryId == categoryId)
            .ToListAsync();
    }

    public async Task DeleteAsync(Guid transactionId)
    {
        var transaction = await _context.Transactions.FindAsync(transactionId);
        if (transaction != null)
        {
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
        }
    }
}
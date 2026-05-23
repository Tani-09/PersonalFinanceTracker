using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.Interfaces;
public interface ITransactionRepository
{
    Task AddAsync(Transaction transaction);
    Task<List<Transaction>> GetByUserIdAsync(Guid userId);
    Task<List<Transaction>> GetByCategoryAsync(Guid categoryId);
    Task DeleteAsync(Guid transactionId);
}

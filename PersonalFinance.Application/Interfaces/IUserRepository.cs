using System;
using System.Threading.Tasks;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.Interfaces;
public interface IUserRepository
{
    Task AddAsync(User user);
    Task<User?> GetByEmailAsync(string email);
    Task<User?> GetByIdAsync(Guid id);
}

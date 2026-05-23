using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Application.Interfaces;
public interface ICategoryRepository
{
    Task<List<Category>> GetAllAsync();
    Task<Category?> GetByIdAsync(Guid id);
}

using Microsoft.AspNetCore.Mvc;
using PersonalFinance.Application.DTOs;
using PersonalFinance.Application.Interfaces;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransactionController : ControllerBase
{
    private readonly ITransactionRepository _transactionRepository;

    public TransactionController(
        ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }

    [HttpPost]
    public async Task<IActionResult> AddTransaction(
    CreateTransactionDto dto)
    
    {
      var transaction = new Transaction
      {
        Amount = dto.Amount,
        Type = dto.Type,
        UserId = dto.UserId,
        CategoryId = dto.CategoryId
      };

      await _transactionRepository.AddAsync(transaction);

      return Ok("Transaction added successfully");
    }


    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetTransactionsByUser(Guid userId)
    {
      var transactions = await _transactionRepository.GetByUserIdAsync(userId);

      return Ok(transactions);
     }


     [HttpGet("category/{categoryId}")]
     public async Task<IActionResult> GetTransactionsByCategory(Guid categoryId)
     {
       var transactions = await _transactionRepository.GetByCategoryAsync(categoryId);

        return Ok(transactions);
     }


     [HttpDelete("{transactionId}")]
     public async Task<IActionResult> DeleteTransaction(Guid transactionId)
     {
       await _transactionRepository.DeleteAsync(transactionId);

        return Ok("Transaction deleted successfully");
      }
}
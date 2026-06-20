namespace PersonalFinance.Application.DTOs;

public class CreateTransactionDto
{
    public decimal Amount { get; set; }

    public string Type { get; set; } = string.Empty;

    public Guid UserId { get; set; }

    public Guid CategoryId { get; set; }
}
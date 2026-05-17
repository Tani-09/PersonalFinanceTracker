namespace PersonalFinance.Domain.Entities;

public class Transaction
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid CategoryId { get; set; }

    public decimal Amount { get; set; }

    public string Currency { get; set; } = "INR";

    public string Type { get; set; } = string.Empty; // Credit / Debit

    public DateTime Date { get; set; } = DateTime.UtcNow;

    public string? Notes { get; set; }
}
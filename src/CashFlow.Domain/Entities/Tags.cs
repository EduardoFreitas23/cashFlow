namespace CashFlow.Domain.Entities;

public class Tags {
    public long Id {  get; set; }
    public Enums.Tags Value { get; set; }

    public long ExpenseId { get; set; }
    public Expense Expense { get; set; } = default!;
}

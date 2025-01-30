using CashFlow.Communication.Requests;

namespace CashFlow.Application.UseCases.Expenses.Updates;
public interface IUpdateExpenseUseCase {
    Task Execute(long id, RequestExpenseJson request);
}

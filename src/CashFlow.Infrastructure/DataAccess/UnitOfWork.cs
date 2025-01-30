using CashFlow.Domain.Repositories;

namespace CashFlow.Infrastructure.DataAccess;
internal class UnitOfWork : IUnitOfWork {
    private readonly CashFlowDbContext _dbcontext;
    public UnitOfWork(CashFlowDbContext dbContext) {
        _dbcontext = dbContext;
    }
    public async Task Commit() => await _dbcontext.SaveChangesAsync();
}

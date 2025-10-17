using GPSSabores.Domain.Repositories;

namespace GPSSabores.Infrastructure.DataAccess;
public class UnitOfWork : IUnitOfWork
{
    private readonly GpsSaboresDbContext _dbContext;

    public UnitOfWork(GpsSaboresDbContext dbContext) => _dbContext = dbContext;

    public async Task Commit() => await _dbContext.SaveChangesAsync();

}

namespace GPSSabores.Domain.Repositories;
public interface IUnitOfWork
{
    public Task Commit();
}

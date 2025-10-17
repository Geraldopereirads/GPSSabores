namespace GPSSabores.Domain.Repositories.User;
public interface IUserWriteOnlyRepository
{
    public Task Add(Entities.User user);
}

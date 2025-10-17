using GPSSabores.Domain.Entities;
using GPSSabores.Domain.Repositories.User;
using Microsoft.EntityFrameworkCore;

namespace GPSSabores.Infrastructure.DataAccess.Repositories;
public class UserRepository : IUserWriteOnlyRepository, IUserReadOnlyRepository
{
    private readonly GpsSaboresDbContext _dbContext;

    public UserRepository(GpsSaboresDbContext dbContext) => _dbContext = dbContext;

    public async Task Add(User user) => await _dbContext.Users.AddAsync(user);


    public async Task<bool> ExistActiveUserWithEmail(string email)
    {
        return await _dbContext.Users.AnyAsync(user => user.Email.Equals(email) && user.Active);
    }

}

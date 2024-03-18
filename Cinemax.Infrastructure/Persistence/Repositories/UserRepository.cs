using Cinemax.Application.Common.Interfaces.Persistence;
using Cinemax.Domain.User;

namespace Cinemax.Infrastructure.Persistence.Repositories;
public class UserRepository : IUserRepository{
    private static readonly List<User> _users = new();
    public void Add(User user){
        _users.Add(user);
    }

    public User? GetUserByEmail(string Email){
        return _users.SingleOrDefault(user => user.Email == Email); 
    }
}
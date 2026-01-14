using AuthBackend.Domain.Entities;
using AuthBackend.Domain.Repositories;

namespace AuthBackend.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new();

        public User? GetByEmail(string email)
        {
            return _users.FirstOrDefault(u => u.Email == email);
        }

        public User? GetByNameAndEmail(string name, string email)
        {
            return _users.FirstOrDefault(u => u.Name == name && u.Email == email);
        }

        public void Add(User user)
        {
            _users.Add(user);
        }
    }
}

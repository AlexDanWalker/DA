using AuthBackend.Domain.Entities;

namespace AuthBackend.Domain.Repositories
{
    public interface IUserRepository
    {
        User? GetByEmail(string email);
        User? GetByNameAndEmail(string name, string email);
        void Add(User user);
    }
}

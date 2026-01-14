using AuthBackend.Domain.Entities;
using AuthBackend.Domain.Repositories;

namespace AuthBackend.Application.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? Register(string name, string email)
        {
            if (_userRepository.GetByEmail(email) != null)
                return null; // usuario ya existe

            var id = new Random().Next(1, 10000); // simulación de Id
            var user = new User(id, name, email);
            _userRepository.Add(user);
            return user;
        }

        public User? Login(string name, string email)
        {
            return _userRepository.GetByNameAndEmail(name, email);
        }
    }
}

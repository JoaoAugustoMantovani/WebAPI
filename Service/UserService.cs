using WebAPI.Models;
using WebAPI.Repository;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(IUserRepository userRepository, IPasswordHasher<User> passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<User> CreateUser(UserDTO user)
        {
            var hashedPassword = _passwordHasher.HashPassword(new User(user.Email, user.Name, user.Senha, user.Idade), user.Senha);
            var userModel = User.CreateUser(user.Email, user.Name, user.Idade, hashedPassword);
            return await _userRepository.CreateUser(userModel);
        }

        public async Task DeleteUser(Guid userId)
        {
            var user = await _userRepository.GetUserById(userId);
            if (user == null)
                throw new Exception("Usuário não encontrado");

            await _userRepository.DeleteUser(user);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers() ?? throw new Exception("Usuários não encontrados");
        }

        public async Task<User> GetUserById(Guid userId)
        {
            var user = await _userRepository.GetUserById(userId);

            if (user == null)
                throw new Exception("Usuário não encontrado");

            return user;
        }

        public async Task<bool> UpdateUser(UserDTO request, Guid id)
        {
            var user = await _userRepository.GetUserById(id) ?? throw new Exception("Usuário não encontrado");
           
            var hashedPassword = _passwordHasher.HashPassword(
                new User(request.Email, request.Name, request.Senha, request.Idade),
                request.Senha);
    
            var updateModel = user.UpdateUser(request.Email, request.Name, request.Idade, hashedPassword);
            await _userRepository.UpdateUser(updateModel);

            return true;
        }
    }
}
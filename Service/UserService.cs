using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUser(UserDTO user)
        {
            var userModel = new User(user.Email, user.Name, user.Idade);
            return await _userRepository.CreateUser(userModel);
        }
    }
}
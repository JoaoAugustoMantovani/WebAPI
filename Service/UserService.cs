using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Repository;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        byte[] salt = RandomNumberGenerator.GetBytes(12888/8);

        public async Task<User> CreateUser(UserDTO user)
        {   

            // string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            //     password: 
            // ));

            var userModel = User.CreateUser(user.Email, user.Name, user.Idade, user.Senha);
            return await _userRepository.CreateUser(userModel);
        }
    }
}
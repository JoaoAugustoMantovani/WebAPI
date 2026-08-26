using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Service
{
    public interface IUserService
    {
        Task<User> CreateUser(UserDTO user);
    }
}
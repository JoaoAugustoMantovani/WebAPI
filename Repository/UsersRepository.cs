using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class UsersRepository : IUserRepository
    {

        private readonly AppDbContext _appDbContext;
        public UsersRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<User> CreateUser(User user)
        {
            _appDbContext.User.Add(user);
            await _appDbContext.SaveChangesAsync();

            return user;
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
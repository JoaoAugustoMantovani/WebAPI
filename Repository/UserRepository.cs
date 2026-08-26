using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly AppDbContext _appDbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<User> CreateUser(User user)
        {
            try
            {
            _appDbContext.User.Add(user);
            await _appDbContext.SaveChangesAsync();
            }
            catch(DbUpdateException)
            {
                throw new Exception("Erro ao salvar no banco");
            }
            return user;
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
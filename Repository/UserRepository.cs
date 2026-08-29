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
            _appDbContext.User.Add(user);
            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                throw new Exception("Erro ao salvar no banco");
            }
            return user;
        }

        public async Task DeleteUser(User user)
        {
            _appDbContext.User.Remove(user);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<User?> GetUserById(Guid userId)
        {
            var user = await _appDbContext.User.FindAsync(userId);

            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var user = await _appDbContext.User.ToListAsync();

            return user;
        }

        public async Task UpdateUser(User request)
        {
            _appDbContext.Update(request);
            await _appDbContext.SaveChangesAsync();
        }

         public void Dispose()
        {
            _appDbContext.Dispose();
        }
    }
}
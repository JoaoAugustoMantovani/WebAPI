using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IUserRepository : IDisposable
    {
        Task<User> CreateUser(User user);
        Task DeleteUser(User user);
        Task<User?> GetUserById(Guid userId);
        Task<List<User>> GetAllUsers();
        Task UpdateUser(User request);
    }
}
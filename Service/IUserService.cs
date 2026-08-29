using WebAPI.Models;

namespace WebAPI.Service
{
    public interface IUserService
    {
        Task<User> CreateUser(UserDTO user);
        Task DeleteUser(Guid userId);
        Task<User> GetUserById(Guid userId);
        Task<List<User>> GetAllUsers();
        Task<bool> UpdateUser(UserDTO request, Guid id);
    }
}
using InventoryManagement.Entities;

namespace InventoryManagement.Services
{
    public interface IUserService : IBaseService<User>
    {
        IEnumerable<User>? GetAllByRole(Guid? id);
        User Authenticate(string username, string password);
        Task<User> Create(User user, string password);
        Task<bool> UpdateUser(User user, string password);
    }
}

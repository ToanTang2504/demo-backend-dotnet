using InventoryManagement.Entities;

namespace InventoryManagement.Services
{
    public interface IRoleService : IBaseService<Role>
    {
        Task<Role> Create(Role role);
        Task<bool> UpdateRole(Role role);
    }
}

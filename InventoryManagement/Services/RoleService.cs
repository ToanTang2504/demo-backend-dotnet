using InventoryManagement.Entities;

namespace InventoryManagement.Services
{
    public class RoleService : BaseService<Role>, IRoleService
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public RoleService(DataContext dataContext, IServiceScopeFactory scopeFactory) : base(dataContext)
        {
            _scopeFactory = scopeFactory;
        }

        public async Task<Role> Create(Role role)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateRole(Role role)
        {
            throw new NotImplementedException();
        }
    }
}

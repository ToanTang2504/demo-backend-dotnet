using InventoryManagement.Entities;
using InventoryManagement.Helpers;

namespace InventoryManagement.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public UserService(DataContext dataContext, IServiceScopeFactory scopeFactory) : base(dataContext)
        {
            _scopeFactory = scopeFactory;
        }

        public async override Task<User?> Get(Guid id)
        {
            var selectedUser = await base.Get(id);
            return (selectedUser != null && selectedUser.IsDeleted) ? null : selectedUser;
        }

        public IEnumerable<User>? GetAllByRole(Guid? id)
        {
            IEnumerable<User>? result = null;

            using (var scope = _scopeFactory.CreateScope())
            {
                var roleContext = scope.ServiceProvider.GetService<IRoleService>();
                var roles = roleContext?.Find(x => x.IsDeleted == false);
                
                if (roles != null)
                {
                    var users = (from a in base.Find(x => x.IsDeleted == false)
                                 join b in roles on a.RoleId equals b.Id
                                 select a).ToList();

                    if (id != null || id != default(Guid))
                    {
                        result = users.Where(x => x.RoleId == id);
                    }
                    else
                    {
                        result = users;
                    }
                }
            }

            return result;
        }

        public User Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Create(User user, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateUser(User user, string password)
        {
            if (user == null) throw new ArgumentNullException("user");

            var selectedUser = await Get(user.Id);

            if (selectedUser == null) throw new InvalidOperationException("User not found.");

            if (!string.IsNullOrWhiteSpace(user.FirstName) && selectedUser.FirstName != user.FirstName)
            {
                selectedUser.FirstName = user.FirstName;
            }

            if (!string.IsNullOrWhiteSpace(user.LastName) && selectedUser.LastName != user.LastName)
            {
                selectedUser.LastName = user.LastName;
            }

            if (selectedUser.EmailAddress != user.EmailAddress)
            {
                selectedUser.EmailAddress = user.EmailAddress;
            }

            if (!string.IsNullOrWhiteSpace(password))
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                selectedUser.PasswordHash = passwordHash;
                selectedUser.PasswordSalt = passwordSalt;
            }

            if (user.RoleId != default(Guid) && selectedUser.RoleId != user.RoleId)
            {
                selectedUser.RoleId = user.RoleId;
            }

            base.Update(selectedUser);

            return await _context.SaveChangesAsync() > 0;
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException(Constants.ErrorMessage.IsNullOrWhiteSpace, "password");

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}

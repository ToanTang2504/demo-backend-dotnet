using InventoryManagement.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static InventoryManagement.Helpers.Constants;

namespace InventoryManagement.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;

        public UsersController(IConfiguration configuration, IUserService userService, IRoleService roleService)
        {
            _configuration = configuration;
            _userService = userService;
            _roleService = roleService;
        }

        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(JsonResult), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorMessage), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var user = await _userService.Get(Guid.Parse(id));
                if (user != null)
                {
                    return Ok(new JsonResult(new
                    {
                        user.FullName,
                        user.EmailAddress,
                        user.RoleId
                    }));
                }
                else
                {
                    throw new Exception("User not found.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new JsonResult(new
                {
                    ex.Message,
                    innerException = ex.InnerException?.Message,
                    ex.StackTrace
                }));
            }
        }
    }
}

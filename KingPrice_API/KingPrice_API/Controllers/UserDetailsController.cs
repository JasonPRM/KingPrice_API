using KingPrice_API.Services.UserDetailsService;
using KingPrice_API.Services.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KingPrice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetailsService _userDetailsService;

        public UserDetailsController(IUserDetailsService userDetailsService)
        {
            _userDetailsService = userDetailsService;
        }

        [HttpGet]
        [Route("GetAllUserDetails", Name = "GetAllUserDetails")]
        public async Task<ActionResult<List<Users>>> GetAllUserDetails()
        {
            var result = await _userDetailsService.GetAllUserDetails();

            if (result.Count() == 0)
                return NotFound("No users found.");

            return Ok(result);
        }
    }
}

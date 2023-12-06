using KingPrice_API.Services.UserService;
using Microsoft.AspNetCore.Mvc;

namespace KingPrice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetAllUsers", Name = "GetAllUsers")]
        public async Task<ActionResult<List<Users>>> GetAllUsers()
        {
            var result = await _userService.GetAllUsers();

            if (result.Count() == 0)
                return NotFound("No users found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetUserByID/{id:int}", Name = "GetUserByID")]
        public async Task<ActionResult<Users>> GetUserByID(int id)
        {
            var result = await _userService.GetUserByID(id);

            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetUsersByFirstname/{firstname}", Name = "GetUsersByFirstname")]
        public async Task<ActionResult<List<Users>>> GetUsersByFirstname(string firstname)
        {
            var result = await _userService.GetUsersByFirstname(firstname);

            if (result.Count() == 0)
                return NotFound("No users found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetUsersBySurname/{surname}", Name = "GetUsersBySurname")]
        public async Task<ActionResult<List<Users>>> GetUsersBySurname(string surname)
        {
            var result = await _userService.GetUsersBySurname(surname);

            if (result.Count() == 0)
                return NotFound("No users found.");

            return Ok(result);
        }

        [HttpPost]
        [Route("AddUser", Name = "AddUser")]
        public async Task<ActionResult<Users>> AddUser(Users user)
        {
            var result = await _userService.AddUser(user);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateUser")]
        public async Task<ActionResult<Users>> UpdateUser(Users user)
        {
            var result = await _userService.UpdateUser(user);

            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteUser/{id:int}", Name = "DeleteUser")]
        public async Task<ActionResult<Users>> DeleteUser(int id)
        {
            var result = await _userService.DeleteUser(id);

            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }
    }
}

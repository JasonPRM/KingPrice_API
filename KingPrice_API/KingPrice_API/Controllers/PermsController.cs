using KingPrice_API.Services.PermsService;
using Microsoft.AspNetCore.Mvc;

namespace KingPrice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermsController : ControllerBase
    {
        private readonly IPermsService _permsService;

        public PermsController(IPermsService permsService)
        {
            _permsService = permsService;
        }

        [HttpGet]
        [Route("GetAllPerms", Name = "GetAllPerms")]
        public async Task<ActionResult<List<Perms>>> GetAllPerms()
        {
            var result = await _permsService.GetAllPerms();

            if (result.Count() == 0)
                return NotFound("No permissions found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetPermsByID/{id:int}", Name = "GetPermsByID")]
        public async Task<ActionResult<Perms>> GetPermsByID(int id)
        {
            var result = await _permsService.GetPermsByID(id);

            if (result is null)
                return NotFound("Permissions not found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetPermsByname/{name}", Name = "GetPermsByname")]
        public async Task<ActionResult<List<Perms>>> GetPermsByname(string name)
        {
            var result = await _permsService.GetPermsByName(name);

            if (result.Count() == 0)
                return NotFound("No permissions found.");

            return Ok(result);
        }

        [HttpPost]
        [Route("AddPermissions", Name = "AddPermissions")]
        public async Task<ActionResult<Perms>> AddPermissions(Perms perms)
        {
            var result = await _permsService.AddPerms(perms);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdatePerms")]
        public async Task<ActionResult<Perms>> UpdatePerms(Perms perms)
        {
            var result = await _permsService.UpdatePerms(perms);

            if (result is null)
                return NotFound("Permissions not found.");

            return Ok(result);
        }

        [HttpDelete]
        [Route("DeletePerms/{id:int}", Name = "DeletePerms")]
        public async Task<ActionResult<Perms>> DeletePerms(int id)
        {
            var result = await _permsService.DeletePerms(id);

            if (result is null)
                return NotFound("Permissions not found.");

            return Ok(result);
        }
    }
}

using KingPrice_API.Services.GroupPermissionsService;
using Microsoft.AspNetCore.Mvc;

namespace KingPrice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupPermissionsController : ControllerBase
    {
        private readonly IGroupPermissionsService _groupPermsService;

        public GroupPermissionsController(IGroupPermissionsService groupPermsService)
        {
            _groupPermsService = groupPermsService;
        }

        [HttpGet]
        [Route("GetAllGroupPermissions", Name = "GetAllGroupPermissions")]
        public async Task<ActionResult<List<GroupPermissions>>> GetAllGroupPermissions()
        {
            var result = await _groupPermsService.GetAllGroupPermissions();

            if (result.Count() == 0)
                return NotFound("No group permissions found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetGroupPermsByID/{id:int}", Name = "GetGroupPermsByID")]
        public async Task<ActionResult<GroupPermissions>> GetGroupPermsByID(int id)
        {
            var result = await _groupPermsService.GetGroupPermsByID(id);

            if (result is null)
                return NotFound("Group permissions not found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetGroupPermsByGroupID/{groupID:int}", Name = "GetGroupPermsByGroupID")]
        public async Task<ActionResult<List<GroupPermissions>>> GetGroupPermsByGroupID(int groupID)
        {
            var result = await _groupPermsService.GetGroupPermsByGroupID(groupID);

            if (result.Count() == 0)
                return NotFound("No group permissions found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetGroupPermsByPermsID/{permID:int}", Name = "GetGroupPermsByPermsID")]
        public async Task<ActionResult<List<GroupPermissions>>> GetGroupPermsByPermsID(int permID)
        {
            var result = await _groupPermsService.GetGroupPermsByPermsID(permID);

            if (result.Count() == 0)
                return NotFound("No group permissions found.");

            return Ok(result);
        }

        [HttpPost]
        [Route("AddGroupPermissions", Name = "AddGroupPermissions")]
        public async Task<ActionResult<GroupPermissions>> AddGroupPermissions(GroupPermissions groupPerms)
        {
            var result = await _groupPermsService.AddGroupPerms(groupPerms);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateGroupPerms")]
        public async Task<ActionResult<GroupPermissions>> UpdateGroupPerms(GroupPermissions grouPerms)
        {
            var result = await _groupPermsService.UpdateGroupPerms(grouPerms);

            if (result is null)
                return NotFound("Group permissions not found.");

            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteGroupPerms/{id:int}", Name = "DeleteGroupPerms")]
        public async Task<ActionResult<GroupPermissions>> DeleteGroupPerms(int id)
        {
            var result = await _groupPermsService.DeleteGroupPerms(id);

            if (result is null)
                return NotFound("Group permissions not found.");

            return Ok(result);
        }
    }
}

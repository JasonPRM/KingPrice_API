using KingPrice_API.Services.GroupsService;
using KingPrice_API.Services.UserGroupsService;
using Microsoft.AspNetCore.Mvc;

namespace KingPrice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupsController : ControllerBase
    {
        private readonly IUserGroupsService _userGroupsService;

        public UserGroupsController(IUserGroupsService userGroupsService)
        {
            _userGroupsService = userGroupsService;
        }

        [HttpGet]
        [Route("GetAllUserGroups", Name = "GetAllUserGroups")]
        public async Task<ActionResult<List<UserGroups>>> GetAllUserGroups()
        {
            var result = await _userGroupsService.GetAllUserGroups();

            if (result.Count() == 0)
                return NotFound("No user group found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetUserGroupByID/{id:int}", Name = "GetUserGroupByID")]
        public async Task<ActionResult<UserGroups>> GetUserGroupByID(int id)
        {
            var result = await _userGroupsService.GetUserGroupByID(id);

            if (result is null)
                return NotFound("User group not found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetUserGroupsByUserID/{userID:int}", Name = "GetUserGroupsByUserID")]
        public async Task<ActionResult<List<UserGroups>>> GetUserGroupsByUserID(int userID)
        {
            var result = await _userGroupsService.GetUserGroupsByUserID(userID);

            if (result.Count() == 0)
                return NotFound("No user group found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetUserGroupsByGroupID/{groupID:int}", Name = "GetUserGroupsByGroupID")]
        public async Task<ActionResult<List<UserGroups>>> GetUserGroupsByGroupID(int groupID)
        {
            var result = await _userGroupsService.GetUserGroupsByGroupID(groupID);

            if (result.Count() == 0)
                return NotFound("No user group found.");

            return Ok(result);
        }

        [HttpPost]
        [Route("AddUserGroup", Name = "AddUserGroup")]
        public async Task<ActionResult<UserGroups>> AddUserGroup(UserGroups user)
        {
            var result = await _userGroupsService.AddUserGroup(user);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateUserGroup")]
        public async Task<ActionResult<UserGroups>> UpdateUserGroup(UserGroups userGroup)
        {
            var result = await _userGroupsService.UpdateUserGroup(userGroup);

            if (result is null)
                return NotFound("User group not found.");

            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteUserGroup/{id:int}", Name = "DeleteUserGroup")]
        public async Task<ActionResult<UserGroups>> DeleteUserGroup(int id)
        {
            var result = await _userGroupsService.DeleteUserGroup(id);

            if (result is null)
                return NotFound("User group not found.");

            return Ok(result);
        }
    }
}

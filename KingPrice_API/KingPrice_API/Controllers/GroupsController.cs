using KingPrice_API.Services.GroupsService;
using Microsoft.AspNetCore.Mvc;

namespace KingPrice_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupsService _groupsService;

        public GroupsController(IGroupsService groupsService)
        {
            _groupsService = groupsService;
        }

        [HttpGet]
        [Route("GetAllGroups", Name = "GetAllGroups")]
        public async Task<ActionResult<List<Groups>>> GetAllGroups()
        {
            var result = await _groupsService.GetAllGroups();

            if (result is null)
                return NotFound("No group found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetGroupByID/{id:int}", Name = "GetGroupByID")]
        public async Task<ActionResult<Groups>> GetGroupByID(int id)
        {
            var result = await _groupsService.GetGroupByID(id);

            if (result is null)
                return NotFound("Group not found.");

            return Ok(result);
        }

        [HttpGet]
        [Route("GetGroupByname/{name}", Name = "GetGroupByname")]
        public async Task<ActionResult<List<Groups>>> GetGroupByname(string name)
        {
            var result = await _groupsService.GetGroupByName(name);

            if (result.Count() == 0)
                return NotFound("No group found.");

            return Ok(result);
        }

        [HttpPost]
        [Route("AddGroup", Name = "AddGroup")]
        public async Task<ActionResult<Groups>> AddGroup(Groups group)
        {
            var result = await _groupsService.AddGroup(group);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateGroup")]
        public async Task<ActionResult<Groups>> UpdateGroup(Groups group)
        {
            var result = await _groupsService.UpdateGroup(group);

            if (result is null)
                return NotFound("Group not found.");

            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteGroup/{id:int}", Name = "DeleteGroup")]
        public async Task<ActionResult<Groups>> DeleteGroup(int id)
        {
            var result = await _groupsService.DeleteGroup(id);

            if (result is null)
                return NotFound("Group not found.");

            return Ok(result);
        }
    }
}

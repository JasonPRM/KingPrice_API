using KingPrice_API.Data;
using Microsoft.EntityFrameworkCore;

namespace KingPrice_API.Services.GroupsService
{
    public class GroupsService : IGroupsService
    {
        private readonly KingPriceDBContext _context;

        public GroupsService(KingPriceDBContext context)
        {
            _context = context;
        }

        public async Task<Groups?> AddGroup(Groups group)
        {
            if (!(group is null))
            {
                group.DateCreated = DateTime.Now;
                _context.Groups.Add(group);
                await _context.SaveChangesAsync();

                return group;
            }
            else
            {
                return null;
            }
        }

        public async Task<Groups?> DeleteGroup(int id)
        {
            var group = await _context.Groups.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (group is null)
                return null;

            _context.Groups.Remove(group);
            await _context.SaveChangesAsync();

            return group;
        }

        public async Task<List<Groups>> GetAllGroups()
        {
            var group = await _context.Groups.ToListAsync();
            return group;
        }

        public async Task<Groups?> GetGroupByID(int id)
        {
            var group = await _context.Groups.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (group is null)
                return null;

            return group;
        }

        public async Task<List<Groups>> GetGroupByName(string name)
        {
            var group = await _context.Groups.Where(x => x.Name == name).ToListAsync();
            return group;
        }

        public async Task<Groups?> UpdateGroup(Groups group)
        {
            var groupUpdated = await _context.Groups.Where(x => x.ID == group.ID).FirstOrDefaultAsync();

            if (groupUpdated is null)
                return null;

            groupUpdated.Name = group.Name;
            groupUpdated.Description = group.Description;
            groupUpdated.DateUpdated = DateTime.Now;//We have this for audit keeping purposes

            await _context.SaveChangesAsync();

            return groupUpdated;
        }
    }
}

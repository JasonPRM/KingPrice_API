using KingPrice_API.Data;
using Microsoft.EntityFrameworkCore;

namespace KingPrice_API.Services.GroupPermissionsService
{
    public class GroupPermissionsService : IGroupPermissionsService
    {
        private readonly KingPriceDBContext _context;

        public GroupPermissionsService(KingPriceDBContext context)
        {
            _context = context;
        }

        public async Task<GroupPermissions?> AddGroupPerms(GroupPermissions groupPerms)
        {
            if (!(groupPerms is null))
            {
                groupPerms.DateCreated = DateTime.Now;
                _context.GroupPermissions.Add(groupPerms);
                await _context.SaveChangesAsync();

                return groupPerms;
            }
            else
            {
                return null;
            }
        }

        public async Task<GroupPermissions?> DeleteGroupPerms(int id)
        {
            var groupPerms = await _context.GroupPermissions.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (groupPerms is null)
                return null;

            _context.GroupPermissions.Remove(groupPerms);
            await _context.SaveChangesAsync();

            return groupPerms;
        }

        public async Task<List<GroupPermissions>> GetAllGroupPermissions()
        {
            var groupPerms = await _context.GroupPermissions.ToListAsync();
            return groupPerms;
        }

        public async Task<GroupPermissions?> GetGroupPermsByID(int id)
        {
            var groupPerms = await _context.GroupPermissions.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (groupPerms is null)
                return null;

            return groupPerms;
        }

        public async Task<List<GroupPermissions>> GetGroupPermsByGroupID(int groupID)
        {
            var groupPerms = await _context.GroupPermissions.Where(x => x.GroupID == groupID).ToListAsync();
            return groupPerms;
        }

        public async Task<List<GroupPermissions>> GetGroupPermsByPermsID(int permID)
        {
            var groupPerms = await _context.GroupPermissions.Where(x => x.PermissionsID == permID).ToListAsync();
            return groupPerms;
        }

        public async Task<GroupPermissions?> UpdateGroupPerms(GroupPermissions groupPerms)
        {
            var groupUpdated = await _context.GroupPermissions.Where(x => x.ID == groupPerms.ID).FirstOrDefaultAsync();

            if (groupUpdated is null)
                return null;

            groupUpdated.GroupID = groupPerms.GroupID;
            groupUpdated.PermissionsID = groupPerms.PermissionsID;
            groupUpdated.DateUpdated = DateTime.Now;//We have this for audit keeping purposes

            await _context.SaveChangesAsync();

            return groupUpdated;
        }
    }
}

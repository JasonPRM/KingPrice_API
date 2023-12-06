using KingPrice_API.Data;
using KingPrice_API.Models;
using Microsoft.EntityFrameworkCore;

namespace KingPrice_API.Services.UserGroupsService
{
    public class UserGroupsService : IUserGroupsService
    {
        private readonly KingPriceDBContext _context;

        public UserGroupsService(KingPriceDBContext context)
        {
            _context = context;
        }

        public async Task<UserGroups?> AddUserGroup(UserGroups userGroup)
        {
            if (!(userGroup is null))
            {
                userGroup.DateCreated = DateTime.Now;
                _context.UserGroups.Add(userGroup);
                await _context.SaveChangesAsync();

                return userGroup;
            }
            else
            {
                return null;
            }
        }

        public async Task<UserGroups?> DeleteUserGroup(int id)
        {
            var userGroup = await _context.UserGroups.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (userGroup is null)
                return null;

            _context.UserGroups.Remove(userGroup);
            await _context.SaveChangesAsync();

            return userGroup;
        }

        public async Task<List<UserGroups>> GetAllUserGroups()
        {
            var userGroup = await _context.UserGroups.ToListAsync();
            return userGroup;
        }

        public async Task<UserGroups?> GetUserGroupByID(int id)
        {
            var userGroup = await _context.UserGroups.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (userGroup is null)
                return null;

            return userGroup;
        }

        public async Task<List<UserGroups>> GetUserGroupsByUserID(int id)
        {
            var userGroup = await _context.UserGroups.Where(x => x.UserID == id).ToListAsync();
            return userGroup;
        }

        public async Task<List<UserGroups>> GetUserGroupsByGroupID(int id)
        {
            var userGroup = await _context.UserGroups.Where(x => x.GroupID == id).ToListAsync();
            return userGroup;
        }

        public async Task<UserGroups?> UpdateUserGroup(UserGroups userGroup)
        {
            var groupUpdated = await _context.UserGroups.Where(x => x.ID == userGroup.ID).FirstOrDefaultAsync();

            if (groupUpdated is null)
                return null;

            groupUpdated.UserID = userGroup.UserID;
            groupUpdated.GroupID = userGroup.GroupID;
            groupUpdated.DateUpdated = DateTime.Now;//We have this for audit keeping purposes

            await _context.SaveChangesAsync();

            return groupUpdated;
        }
    }
}

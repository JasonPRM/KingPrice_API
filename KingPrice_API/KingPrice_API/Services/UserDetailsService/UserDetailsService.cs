using KingPrice_API.Data;
using KingPrice_API.Services.GroupsService;
using KingPrice_API.Services.UserGroupsService;
using KingPrice_API.Services.UserService;
using Microsoft.EntityFrameworkCore;

namespace KingPrice_API.Services.UserDetailsService
{
    public class UserDetailsService : IUserDetailsService
    {
        private readonly KingPriceDBContext _context;

        public UserDetailsService(KingPriceDBContext context)
        {
            _context = context;
        }

        public async Task<List<UserDetails>> GetAllUserDetails()
        {
            var userDetials = (from ug in _context.UserGroups
                                join g in _context.Groups on ug.GroupID equals g.ID
                                join gp in _context.GroupPermissions on g.ID equals gp.GroupID
                                join p in _context.Perms on gp.PermissionsID equals p.ID
                                join u in _context.Users on ug.UserID equals u.ID
                                orderby u.Firstname, u.Surname ascending
                                select new UserDetails()
                                {
                                    UserID = u.ID,
                                    Firstname = u.Firstname,
                                    Surname = u.Surname,
                                    Email = u.Email,
                                    GroupName = g.Name,
                                    PermissionName = p.Name,
                                    DateCreated = u.DateCreated,
                                    DateUpdated = u.DateUpdated
                                }).ToListAsync();

            return await userDetials;
        }
    }
}

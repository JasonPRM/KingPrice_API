using KingPrice_API.Data;
using KingPrice_API.Models;
using Microsoft.EntityFrameworkCore;

namespace KingPrice_API.Services.PermsService
{
    public class PermsService : IPermsService
    {
        private readonly KingPriceDBContext _context;

        public PermsService(KingPriceDBContext context)
        {
            _context = context;
        }

        public async Task<Perms?> AddPerms(Perms perms)
        {
            if (!(perms is null))
            {
                perms.DateCreated = DateTime.Now;
                _context.Perms.Add(perms);
                await _context.SaveChangesAsync();

                return perms;
            }
            else
            {
                return null;
            }
        }

        public async Task<Perms?> DeletePerms(int id)
        {
            var perms = await _context.Perms.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (perms is null)
                return null;

            _context.Perms.Remove(perms);
            await _context.SaveChangesAsync();

            return perms;
        }

        public async Task<List<Perms>> GetAllPerms()
        {
            var perms = await _context.Perms.ToListAsync();
            return perms;
        }

        public async Task<Perms?> GetPermsByID(int id)
        {
            var perms = await _context.Perms.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (perms is null)
                return null;

            return perms;
        }

        public async Task<List<Perms>> GetPermsByName(string name)
        {
            var perms = await _context.Perms.Where(x => x.Name == name).ToListAsync();
            return perms;
        }

        public async Task<Perms?> UpdatePerms(Perms perms)
        {
            var permsUpdated = await _context.Perms.Where(x => x.ID == perms.ID).FirstOrDefaultAsync();

            if (permsUpdated is null)
                return null;

            permsUpdated.Name = perms.Name;
            permsUpdated.DateUpdated = DateTime.Now;//We have this for audit keeping purposes

            await _context.SaveChangesAsync();

            return permsUpdated;
        }
    }
}

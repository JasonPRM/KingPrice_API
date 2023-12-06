using KingPrice_API.Data;
using Microsoft.EntityFrameworkCore;

namespace KingPrice_API.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly KingPriceDBContext _context;

        public UserService(KingPriceDBContext context) 
        {
            _context = context;
        }

        public async Task<Users?> AddUser(Users user)
        {
            if (!(user is null))
            {
                user.DateCreated = DateTime.Now;
                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                return user;
            }
            else
            {
                return null;
            }
        }

        public async Task<Users?> DeleteUser(int id)
        {
            var user = await _context.Users.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<List<Users>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<Users?> GetUserByID(int id)
        {
            var user = await _context.Users.Where(x => x.ID == id).FirstOrDefaultAsync();

            if (user is null)
                return null;

            return user;
        }

        public async Task<List<Users>> GetUsersByFirstname(string firstname)
        {
            var users = await _context.Users.Where(x => x.Firstname == firstname).ToListAsync();
            return users;
        }
        public async Task<List<Users>> GetUsersBySurname(string surname)
        {
            var users = await _context.Users.Where(x => x.Surname == surname).ToListAsync();
            return users;
        }

        public async Task<Users?> UpdateUser(Users user)
        {
            var userUpdated = await _context.Users.Where(x => x.ID == user.ID).FirstOrDefaultAsync();

            if (userUpdated is null)
                return null;

            userUpdated.Firstname = user.Firstname;
            userUpdated.Surname = user.Surname;
            userUpdated.Email = user.Email;
            userUpdated.DateUpdated = DateTime.Now;//We have this for audit keeping purposes

            await _context.SaveChangesAsync(); 

            return userUpdated;
        }
    }
}

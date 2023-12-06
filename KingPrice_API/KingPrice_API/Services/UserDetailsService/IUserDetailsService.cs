using KingPrice_API.Services.UserService;

namespace KingPrice_API.Services.UserDetailsService
{
    public interface IUserDetailsService
    {
        Task<List<UserDetails>> GetAllUserDetails();
    }
}

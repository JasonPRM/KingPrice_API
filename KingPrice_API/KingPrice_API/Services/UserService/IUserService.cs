namespace KingPrice_API.Services.UserService
{
    public interface IUserService
    {
        Task<List<Users>> GetAllUsers();

        Task<Users?> GetUserByID(int id);

        Task<List<Users>> GetUsersByFirstname(string name);

        Task<List<Users>> GetUsersBySurname(string name);

        Task<Users?> AddUser(Users user);

        Task<Users?> UpdateUser(Users user);

        Task<Users?> DeleteUser(int id);
    }
}

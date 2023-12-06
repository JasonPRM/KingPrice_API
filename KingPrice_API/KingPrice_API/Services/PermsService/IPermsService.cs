namespace KingPrice_API.Services.PermsService
{
    public interface IPermsService
    {
        Task<List<Perms>> GetAllPerms();

        Task<Perms?> GetPermsByID(int id);

        Task<List<Perms>> GetPermsByName(string name);

        Task<Perms?> AddPerms(Perms perms);

        Task<Perms?> UpdatePerms(Perms perms);

        Task<Perms?> DeletePerms(int id);
    }
}

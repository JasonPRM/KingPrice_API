namespace KingPrice_API.Services.GroupsService
{
    public interface IGroupsService
    {
        Task<List<Groups>> GetAllGroups();

        Task<Groups?> GetGroupByID(int id);

        Task<List<Groups>> GetGroupByName(string name);

        Task<Groups?> AddGroup(Groups group);

        Task<Groups?> UpdateGroup(Groups group);

        Task<Groups?> DeleteGroup(int id);
    }
}

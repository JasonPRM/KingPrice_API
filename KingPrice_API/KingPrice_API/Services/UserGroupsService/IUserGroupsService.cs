namespace KingPrice_API.Services.UserGroupsService
{
    public interface IUserGroupsService
    {
        Task<List<UserGroups>> GetAllUserGroups();

        Task<UserGroups?> GetUserGroupByID(int id);

        Task<List<UserGroups>> GetUserGroupsByUserID(int userID);

        Task<List<UserGroups>> GetUserGroupsByGroupID(int groupID);

        Task<UserGroups?> AddUserGroup(UserGroups userGroup);

        Task<UserGroups?> UpdateUserGroup(UserGroups userGroup);

        Task<UserGroups?> DeleteUserGroup(int id);
    }
}

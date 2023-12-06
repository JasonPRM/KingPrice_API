namespace KingPrice_API.Services.GroupPermissionsService
{
    public interface IGroupPermissionsService
    {
        Task<List<GroupPermissions>> GetAllGroupPermissions();

        Task<GroupPermissions?> GetGroupPermsByID(int id);

        Task<List<GroupPermissions>> GetGroupPermsByGroupID(int groupID);

        Task<List<GroupPermissions>> GetGroupPermsByPermsID(int permID);

        Task<GroupPermissions?> AddGroupPerms(GroupPermissions grouPerms);

        Task<GroupPermissions?> UpdateGroupPerms(GroupPermissions groupPerms);

        Task<GroupPermissions?> DeleteGroupPerms(int id);
    }
}

namespace KingPrice_API.Models
{
    public class UserDetails
    {
        public int UserID { get; set; }

        public string? Firstname { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? GroupName { get; set; }

        public string? PermissionName { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}

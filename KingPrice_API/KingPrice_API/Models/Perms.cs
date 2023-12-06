namespace KingPrice_API.Models
{
    //Permissions
    public class Perms
    {
        public required int ID { get; set; }

        public required string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}

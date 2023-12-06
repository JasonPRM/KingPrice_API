namespace KingPrice_API.Models
{
    public class Users
    {
        public required int ID { get; set; }

        public required string Firstname { get; set; }

        public required string Surname { get; set; }

        public string? Email { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}

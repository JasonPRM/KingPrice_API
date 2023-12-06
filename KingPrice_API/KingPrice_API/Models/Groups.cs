namespace KingPrice_API.Models
{
    public class Groups
    {
        public required int ID { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}

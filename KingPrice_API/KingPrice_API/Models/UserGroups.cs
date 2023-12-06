using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingPrice_API.Models
{
    public class UserGroups
    {
        public required int ID { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual Users? User { get; set; }

        public int GroupID { get; set; }
        [ForeignKey("GroupID")]
        public virtual Groups? Group { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}

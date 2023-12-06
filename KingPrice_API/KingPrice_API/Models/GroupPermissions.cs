using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingPrice_API.Models
{
    public class GroupPermissions
    {
        public required int ID { get; set; }

        public int GroupID { get; set; }
        [ForeignKey("GroupID")]
        public virtual Groups? Group { get; set; }

        public int PermissionsID { get; set; }
        [ForeignKey("PermissionsID")]
        public virtual Perms? Permissions { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }
    }
}

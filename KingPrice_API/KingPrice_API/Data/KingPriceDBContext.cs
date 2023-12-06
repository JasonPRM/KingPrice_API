using KingPrice_API.Services.UserGroupsService;
using Microsoft.EntityFrameworkCore;

namespace KingPrice_API.Data
{
    public class KingPriceDBContext : DbContext
    {
        public KingPriceDBContext(DbContextOptions<KingPriceDBContext> options) : base(options) 
        { 

        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Groups> Groups {  get; set; }

        //Permissions
        public DbSet<Perms> Perms {  get; set; }

        public DbSet<UserGroups> UserGroups { get; set; }

        public DbSet<GroupPermissions> GroupPermissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Perms>().HasData(
                new Perms { ID = 1, Name = "Level 1", DateCreated = DateTime.Now, DateUpdated = null },
                new Perms { ID = 2, Name = "Level 2", DateCreated = DateTime.Now, DateUpdated = null },
                new Perms { ID = 3, Name = "Level 3", DateCreated = DateTime.Now, DateUpdated = null }
            );

            modelBuilder.Entity<Groups>().HasData(
                new Groups { ID = 1, Name = "Group 1", Description = "Description for group 1", DateCreated = DateTime.Now, DateUpdated = null },
                new Groups { ID = 2, Name = "Group 2", Description = "Description for group 2", DateCreated = DateTime.Now, DateUpdated = null },
                new Groups { ID = 3, Name = "Group 3", Description = "Description for group 3", DateCreated = DateTime.Now, DateUpdated = null }
            );

            modelBuilder.Entity<Users>().HasData(
                new Users { ID = 1, Firstname = "Jason", Surname = "Marques", Email = "test@gmail.com", DateCreated = DateTime.Now, DateUpdated = null },
                new Users { ID = 2, Firstname = "John", Surname = "smith", Email = "test2@gmail.com", DateCreated = DateTime.Now, DateUpdated = null },
                new Users { ID = 3, Firstname = "Jack", Surname = "Mark", Email = "test3@gmail.com", DateCreated = DateTime.Now, DateUpdated = null }
            );

            modelBuilder.Entity<GroupPermissions>().HasData(
                new GroupPermissions { ID = 1, GroupID = 1, PermissionsID = 1, DateCreated = DateTime.Now, DateUpdated = null },
                new GroupPermissions { ID = 2, GroupID = 2, PermissionsID = 1, DateCreated = DateTime.Now, DateUpdated = null },
                new GroupPermissions { ID = 3, GroupID = 3, PermissionsID = 1, DateCreated = DateTime.Now, DateUpdated = null },
                new GroupPermissions { ID = 4, GroupID = 1, PermissionsID = 2, DateCreated = DateTime.Now, DateUpdated = null },
                new GroupPermissions { ID = 5, GroupID = 2, PermissionsID = 2, DateCreated = DateTime.Now, DateUpdated = null },
                new GroupPermissions { ID = 6, GroupID = 3, PermissionsID = 2, DateCreated = DateTime.Now, DateUpdated = null },
                new GroupPermissions { ID = 7, GroupID = 1, PermissionsID = 3, DateCreated = DateTime.Now, DateUpdated = null },
                new GroupPermissions { ID = 8, GroupID = 2, PermissionsID = 3, DateCreated = DateTime.Now, DateUpdated = null },
                new GroupPermissions { ID = 9, GroupID = 3, PermissionsID = 3, DateCreated = DateTime.Now, DateUpdated = null }
            );

            modelBuilder.Entity<UserGroups>().HasData(
                new UserGroups { ID = 1, UserID = 1, GroupID = 1, DateCreated = DateTime.Now, DateUpdated = null },
                new UserGroups { ID = 2, UserID = 2, GroupID = 1, DateCreated = DateTime.Now, DateUpdated = null },
                new UserGroups { ID = 3, UserID = 3, GroupID = 1, DateCreated = DateTime.Now, DateUpdated = null },
                new UserGroups { ID = 4, UserID = 1, GroupID = 2, DateCreated = DateTime.Now, DateUpdated = null },
                new UserGroups { ID = 5, UserID = 2, GroupID = 2, DateCreated = DateTime.Now, DateUpdated = null },
                new UserGroups { ID = 6, UserID = 3, GroupID = 2, DateCreated = DateTime.Now, DateUpdated = null },
                new UserGroups { ID = 7, UserID = 1, GroupID = 3, DateCreated = DateTime.Now, DateUpdated = null },
                new UserGroups { ID = 8, UserID = 2, GroupID = 3, DateCreated = DateTime.Now, DateUpdated = null },
                new UserGroups { ID = 9, UserID = 3, GroupID = 3, DateCreated = DateTime.Now, DateUpdated = null }
            );
        }
    }
}

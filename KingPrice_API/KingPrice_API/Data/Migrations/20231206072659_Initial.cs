using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KingPrice_API.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Perms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GroupPermissions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    PermissionsID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPermissions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GroupPermissions_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupPermissions_Perms_PermissionsID",
                        column: x => x.PermissionsID,
                        principalTable: "Perms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserGroups_Groups_GroupID",
                        column: x => x.GroupID,
                        principalTable: "Groups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroups_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "ID", "DateCreated", "DateUpdated", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7689), null, "Description for group 1", "Group 1" },
                    { 2, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7690), null, "Description for group 2", "Group 2" },
                    { 3, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7691), null, "Description for group 3", "Group 3" }
                });

            migrationBuilder.InsertData(
                table: "Perms",
                columns: new[] { "ID", "DateCreated", "DateUpdated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7550), null, "Level 1" },
                    { 2, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7565), null, "Level 2" },
                    { 3, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7566), null, "Level 3" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "DateCreated", "DateUpdated", "Email", "Firstname", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7710), null, "test@gmail.com", "Jason", "Marques" },
                    { 2, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7712), null, "test2@gmail.com", "John", "smith" },
                    { 3, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7713), null, "test3@gmail.com", "Jack", "Mark" }
                });

            migrationBuilder.InsertData(
                table: "GroupPermissions",
                columns: new[] { "ID", "DateCreated", "DateUpdated", "GroupID", "PermissionsID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7732), null, 1, 1 },
                    { 2, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7733), null, 2, 1 },
                    { 3, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7734), null, 3, 1 },
                    { 4, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7735), null, 1, 2 },
                    { 5, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7736), null, 2, 2 },
                    { 6, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7737), null, 3, 2 },
                    { 7, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7738), null, 1, 3 },
                    { 8, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7739), null, 2, 3 },
                    { 9, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7740), null, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "ID", "DateCreated", "DateUpdated", "GroupID", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7762), null, 1, 1 },
                    { 2, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7764), null, 1, 2 },
                    { 3, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7807), null, 1, 3 },
                    { 4, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7809), null, 2, 1 },
                    { 5, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7810), null, 2, 2 },
                    { 6, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7811), null, 2, 3 },
                    { 7, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7812), null, 3, 1 },
                    { 8, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7813), null, 3, 2 },
                    { 9, new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7814), null, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupPermissions_GroupID",
                table: "GroupPermissions",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_GroupPermissions_PermissionsID",
                table: "GroupPermissions",
                column: "PermissionsID");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_GroupID",
                table: "UserGroups",
                column: "GroupID");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_UserID",
                table: "UserGroups",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupPermissions");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Perms");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

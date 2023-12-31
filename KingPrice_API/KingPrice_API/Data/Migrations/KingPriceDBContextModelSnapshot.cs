﻿// <auto-generated />
using System;
using KingPrice_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KingPrice_API.Data.Migrations
{
    [DbContext(typeof(KingPriceDBContext))]
    partial class KingPriceDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KingPrice_API.Models.GroupPermissions", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<int>("PermissionsID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.HasIndex("PermissionsID");

                    b.ToTable("GroupPermissions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7732),
                            GroupID = 1,
                            PermissionsID = 1
                        },
                        new
                        {
                            ID = 2,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7733),
                            GroupID = 2,
                            PermissionsID = 1
                        },
                        new
                        {
                            ID = 3,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7734),
                            GroupID = 3,
                            PermissionsID = 1
                        },
                        new
                        {
                            ID = 4,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7735),
                            GroupID = 1,
                            PermissionsID = 2
                        },
                        new
                        {
                            ID = 5,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7736),
                            GroupID = 2,
                            PermissionsID = 2
                        },
                        new
                        {
                            ID = 6,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7737),
                            GroupID = 3,
                            PermissionsID = 2
                        },
                        new
                        {
                            ID = 7,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7738),
                            GroupID = 1,
                            PermissionsID = 3
                        },
                        new
                        {
                            ID = 8,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7739),
                            GroupID = 2,
                            PermissionsID = 3
                        },
                        new
                        {
                            ID = 9,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7740),
                            GroupID = 3,
                            PermissionsID = 3
                        });
                });

            modelBuilder.Entity("KingPrice_API.Models.Groups", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7689),
                            Description = "Description for group 1",
                            Name = "Group 1"
                        },
                        new
                        {
                            ID = 2,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7690),
                            Description = "Description for group 2",
                            Name = "Group 2"
                        },
                        new
                        {
                            ID = 3,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7691),
                            Description = "Description for group 3",
                            Name = "Group 3"
                        });
                });

            modelBuilder.Entity("KingPrice_API.Models.Perms", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Perms");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7550),
                            Name = "Level 1"
                        },
                        new
                        {
                            ID = 2,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7565),
                            Name = "Level 2"
                        },
                        new
                        {
                            ID = 3,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7566),
                            Name = "Level 3"
                        });
                });

            modelBuilder.Entity("KingPrice_API.Models.UserGroups", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GroupID");

                    b.HasIndex("UserID");

                    b.ToTable("UserGroups");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7762),
                            GroupID = 1,
                            UserID = 1
                        },
                        new
                        {
                            ID = 2,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7764),
                            GroupID = 1,
                            UserID = 2
                        },
                        new
                        {
                            ID = 3,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7807),
                            GroupID = 1,
                            UserID = 3
                        },
                        new
                        {
                            ID = 4,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7809),
                            GroupID = 2,
                            UserID = 1
                        },
                        new
                        {
                            ID = 5,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7810),
                            GroupID = 2,
                            UserID = 2
                        },
                        new
                        {
                            ID = 6,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7811),
                            GroupID = 2,
                            UserID = 3
                        },
                        new
                        {
                            ID = 7,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7812),
                            GroupID = 3,
                            UserID = 1
                        },
                        new
                        {
                            ID = 8,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7813),
                            GroupID = 3,
                            UserID = 2
                        },
                        new
                        {
                            ID = 9,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7814),
                            GroupID = 3,
                            UserID = 3
                        });
                });

            modelBuilder.Entity("KingPrice_API.Models.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7710),
                            Email = "test@gmail.com",
                            Firstname = "Jason",
                            Surname = "Marques"
                        },
                        new
                        {
                            ID = 2,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7712),
                            Email = "test2@gmail.com",
                            Firstname = "John",
                            Surname = "smith"
                        },
                        new
                        {
                            ID = 3,
                            DateCreated = new DateTime(2023, 12, 6, 9, 26, 58, 965, DateTimeKind.Local).AddTicks(7713),
                            Email = "test3@gmail.com",
                            Firstname = "Jack",
                            Surname = "Mark"
                        });
                });

            modelBuilder.Entity("KingPrice_API.Models.GroupPermissions", b =>
                {
                    b.HasOne("KingPrice_API.Models.Groups", "Group")
                        .WithMany()
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KingPrice_API.Models.Perms", "Permissions")
                        .WithMany()
                        .HasForeignKey("PermissionsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("KingPrice_API.Models.UserGroups", b =>
                {
                    b.HasOne("KingPrice_API.Models.Groups", "Group")
                        .WithMany()
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KingPrice_API.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}

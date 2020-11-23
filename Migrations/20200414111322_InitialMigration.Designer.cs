﻿// <auto-generated />
using System;
using ERPCore.AppDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ERPCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200414111322_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("ERPCore.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Address2")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            Address1 = "Tokyo",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        },
                        new
                        {
                            Id = 1,
                            Address1 = "London",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        },
                        new
                        {
                            Id = 2,
                            Address1 = "San Francisco",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        },
                        new
                        {
                            Id = 3,
                            Address1 = "London",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        },
                        new
                        {
                            Id = 4,
                            Address1 = "San Francisco",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        },
                        new
                        {
                            Id = 5,
                            Address1 = "New York",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        },
                        new
                        {
                            Id = 6,
                            Address1 = "London",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        },
                        new
                        {
                            Id = 7,
                            Address1 = "New York",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        },
                        new
                        {
                            Id = 8,
                            Address1 = "New York",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        },
                        new
                        {
                            Id = 9,
                            Address1 = "Edinburgh",
                            City = "unknown",
                            State = "unkown",
                            Zip = "123456"
                        });
                });

            modelBuilder.Entity("ERPCore.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmployeeDepartmentDepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmployeeDepartmentEmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployeeDepartmentEmployeeId", "EmployeeDepartmentDepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Development"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Testing"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Training"
                        },
                        new
                        {
                            Id = 5,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Management"
                        });
                });

            modelBuilder.Entity("ERPCore.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("EmployeeDepartmentDepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EmployeeDepartmentEmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("EmployeeDepartmentEmployeeId", "EmployeeDepartmentDepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 10,
                            Age = 33,
                            DateOfJoining = new DateTime(2008, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Airi.Satou@site.com",
                            FirstName = "Airi",
                            Gender = 1,
                            LastName = "Satou"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 1,
                            Age = 42,
                            DateOfJoining = new DateTime(2009, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Angelica.Ramos@site.com",
                            FirstName = "Angelica",
                            Gender = 1,
                            LastName = "Ramos"
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 2,
                            Age = 66,
                            DateOfJoining = new DateTime(2009, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Ashton.Cox@site.com",
                            FirstName = "Ashton",
                            Gender = 1,
                            LastName = "Cox"
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 3,
                            Age = 41,
                            DateOfJoining = new DateTime(2012, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Bradley.Greer@site.com",
                            FirstName = "Bradley",
                            Gender = 0,
                            LastName = "Greer"
                        },
                        new
                        {
                            Id = 5,
                            AddressId = 4,
                            Age = 28,
                            DateOfJoining = new DateTime(2011, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Brenden.Wagner@site.com",
                            FirstName = "Brenden",
                            Gender = 0,
                            LastName = "Wagner"
                        },
                        new
                        {
                            Id = 6,
                            AddressId = 5,
                            Age = 61,
                            DateOfJoining = new DateTime(2012, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Brielle.Williamson@site.com",
                            FirstName = "Brielle",
                            Gender = 1,
                            LastName = "Williamson"
                        },
                        new
                        {
                            Id = 7,
                            AddressId = 6,
                            Age = 38,
                            DateOfJoining = new DateTime(2011, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Bruno.Nash@site.com",
                            FirstName = "Bruno",
                            Gender = 0,
                            LastName = "Nash"
                        },
                        new
                        {
                            Id = 8,
                            AddressId = 7,
                            Age = 21,
                            DateOfJoining = new DateTime(2011, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Caesar.Vance@site.com",
                            FirstName = "Caesar",
                            Gender = 0,
                            LastName = "Vance"
                        },
                        new
                        {
                            Id = 9,
                            AddressId = 8,
                            Age = 46,
                            DateOfJoining = new DateTime(2011, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Cara.Stevens@site.com",
                            FirstName = "Cara",
                            Gender = 1,
                            LastName = "Stevens"
                        },
                        new
                        {
                            Id = 10,
                            AddressId = 9,
                            Age = 22,
                            DateOfJoining = new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Cedric.Kelly@site.com",
                            FirstName = "Cedric",
                            Gender = 1,
                            LastName = "Kelly"
                        });
                });

            modelBuilder.Entity("ERPCore.Models.EmployeeDepartment", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeId", "DepartmentId");

                    b.ToTable("EmployeeDepartment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "2fe4ab61-3cd9-4ea2-a7d6-86ffe248e4a5",
                            ConcurrencyStamp = "6f29e2d1-2949-4f33-9872-063955190a1b",
                            Name = "user",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "df7239b0-b6b8-4200-bc71-e318335b8043",
                            ConcurrencyStamp = "3999a880-a3ae-43fc-84e0-7a59fb24e67f",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ed62d93e-d0d9-43d1-89e1-20458b5786c5",
                            ConcurrencyStamp = "a6b70544-4a65-43b2-8777-14ce1463346f",
                            Name = "superadmin",
                            NormalizedName = "SUPERADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "7b425f26-2999-4fcd-ab6e-a179a3ff6470",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6fce8b35-54b0-4a68-9a11-cf6d822943e2",
                            Email = "admin@site.co",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@site.co",
                            NormalizedUserName = "Admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEC3vZLOYWa/CXODW05mAQRaVIP6Jfnru3qgZWN6X+xSDDQsUrelo0Z9925QX7TI0yA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "a95902e5-9d6f-4853-a130-46d2da927c59",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8d40ebed-9c8f-4d9e-98fd-2a188f305b2d",
                            Email = "superadmin@site.co",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "superadmin@site.co",
                            NormalizedUserName = "SuperAdmin",
                            PasswordHash = "AQAAAAEAACcQAAAAEFr6/6nXMcUE1fTG9VofTHq901MdZx1qrfIXa4rJR42VSI8/n3dQ5U/GWPvn2tMkpw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "SuperAdmin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "7b425f26-2999-4fcd-ab6e-a179a3ff6470",
                            RoleId = "df7239b0-b6b8-4200-bc71-e318335b8043"
                        },
                        new
                        {
                            UserId = "a95902e5-9d6f-4853-a130-46d2da927c59",
                            RoleId = "ed62d93e-d0d9-43d1-89e1-20458b5786c5"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ERPCore.Models.Department", b =>
                {
                    b.HasOne("ERPCore.Models.Employee", null)
                        .WithMany("Departments")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("ERPCore.Models.EmployeeDepartment", null)
                        .WithMany("Departments")
                        .HasForeignKey("EmployeeDepartmentEmployeeId", "EmployeeDepartmentDepartmentId");
                });

            modelBuilder.Entity("ERPCore.Models.Employee", b =>
                {
                    b.HasOne("ERPCore.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERPCore.Models.EmployeeDepartment", null)
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeDepartmentEmployeeId", "EmployeeDepartmentDepartmentId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

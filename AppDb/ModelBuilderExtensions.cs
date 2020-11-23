using ERPCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPCore.AppDb
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {

            builder.Entity<Address>().HasData( new[] {
                new Address() { Id = 10, Address1 = "Tokyo", State = "unkown", City = "unknown", Zip = "123456" },
                new Address() { Id = 1, Address1 = "London", State = "unkown", City = "unknown", Zip = "123456" },
                new Address() { Id = 2, Address1 = "San Francisco", State = "unkown", City = "unknown", Zip = "123456" },
                new Address() { Id = 3, Address1 = "London", State = "unkown", City = "unknown", Zip = "123456" },
                new Address() { Id = 4, Address1 = "San Francisco", State = "unkown", City = "unknown", Zip = "123456" },
                new Address() { Id = 5, Address1 = "New York", State = "unkown", City = "unknown", Zip = "123456" },
                new Address() { Id = 6, Address1 = "London", State = "unkown", City = "unknown", Zip = "123456" },
                new Address() { Id = 7, Address1 = "New York", State = "unkown", City = "unknown", Zip = "123456" },
                new Address() { Id = 8, Address1 = "New York", State = "unkown", City = "unknown", Zip = "123456" },
                new Address() { Id = 9, Address1 = "Edinburgh", State = "unkown", City = "unknown", Zip = "123456" }}
            );
            
           builder.Entity<Employee>().HasData(
                new {
                    FirstName = "Airi",
                    LastName = "Satou",
                    Email = "Airi.Satou@site.com",
                    AddressId = 10,
                    Age = 33,
                    Gender = Gender.Female,
                    DateOfJoining = new DateTime(2008, 11, 28),
                    Id = 1

                },
                new {
                    FirstName = "Angelica",
                    LastName = "Ramos",
                    Email = "Angelica.Ramos@site.com",
                    AddressId = 1,
                    Age = 42,
                    Gender = Gender.Female,
                    DateOfJoining = new DateTime(2009, 10, 09),
                    Id = 2
                },
                new {
                    FirstName = "Ashton",
                    LastName = "Cox",
                    Email = "Ashton.Cox@site.com",
                    AddressId = 2,
                    Gender = Gender.Female,
                    Age = 66,
                    DateOfJoining = new DateTime(2009, 01, 12),
                    Id = 3
                }, 
                new {
                    FirstName = "Bradley",
                    LastName = "Greer",
                    Email = "Bradley.Greer@site.com",
                    AddressId = 3,
                    Age = 41,
                    Gender = Gender.Male,
                    DateOfJoining = new DateTime(2012, 10, 13),
                    Id = 4
                }, 
                new {
                    FirstName = "Brenden",
                    LastName = "Wagner",
                    Email = "Brenden.Wagner@site.com",
                    AddressId = 4,
                    Age = 28,
                    Gender = Gender.Male,
                    DateOfJoining = new DateTime(2011, 06, 07),
                    Id = 5
                }, 
                new {
                    FirstName = "Brielle",
                    LastName = "Williamson",
                    Email = "Brielle.Williamson@site.com",
                    AddressId = 5,
                    Age = 61,
                    Gender = Gender.Female,
                    DateOfJoining = new DateTime(2012, 12, 02),
                    Id = 6
                },
                new {
                    FirstName = "Bruno",
                    LastName = "Nash",
                    Email = "Bruno.Nash@site.com",
                    AddressId = 6,
                    Age = 38,
                    Gender = Gender.Male,
                    DateOfJoining = new DateTime(2011, 05, 03),
                    Id = 7
                }, 
                new {
                    FirstName = "Caesar",
                    LastName = "Vance",
                    Email = "Caesar.Vance@site.com",
                    AddressId = 7,
                    Age = 21,
                    Gender = Gender.Male,
                    DateOfJoining = new DateTime(2011, 12, 12),
                    Id = 8
                },
                new {
                    FirstName = "Cara",
                    LastName = "Stevens",
                    Email = "Cara.Stevens@site.com",
                    AddressId = 8,
                    Age = 46,
                    Gender = Gender.Female,
                    DateOfJoining = new DateTime(2011, 12, 06),
                    Id = 9
                },
                new {
                    FirstName = "Cedric",
                    LastName = "Kelly",
                    Email = "Cedric.Kelly@site.com",
                    AddressId = 9,
                    Age = 22,
                    Gender = Gender.Female,
                    DateOfJoining = new DateTime(2012, 03, 29),
                    Id = 10
                });

           
            builder.Entity<Department>().HasData(new Department { Id = 1, Name = "Development" },
                 new Department { Id = 3, Name = "Testing" },
                  new Department { Id = 2, Name = "HR" },
                   new Department { Id = 4, Name = "Training" },
                    new Department { Id = 5, Name = "IT" },
                     new Department { Id = 6, Name = "Management" }
            );
        }

        public static void SeedUsers(this ModelBuilder builder)
        {
            var adminRoleId = Guid.NewGuid().ToString();
            var superAdminRoleId = Guid.NewGuid().ToString();
            var adminId = Guid.NewGuid().ToString();
            var superAdminId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "user", NormalizedName = "USER" },
               new IdentityRole { Id= adminRoleId, Name = "admin", NormalizedName = "ADMIN" },
               new IdentityRole { Id = superAdminRoleId, Name = "superadmin", NormalizedName = "SUPERADMIN" });


            var hasher = new PasswordHasher<IdentityUser>();
            var admin = new IdentityUser
            {
                Id = adminId,
                UserName = "Admin",
                NormalizedUserName = "Admin",
                Email = "admin@site.co",
                NormalizedEmail = "admin@site.co",
                EmailConfirmed = true,
                SecurityStamp = string.Empty
            };
            admin.PasswordHash = hasher.HashPassword(admin, "cvbnM!123");
            var superAdmin = new IdentityUser
            {
                Id = superAdminId,
                UserName = "SuperAdmin",
                NormalizedUserName = "SuperAdmin",
                Email = "superadmin@site.co",
                NormalizedEmail = "superadmin@site.co",
                EmailConfirmed = true,
                SecurityStamp = string.Empty
            };
            superAdmin.PasswordHash = hasher.HashPassword(superAdmin, "cvbnM!123");

            builder.Entity<IdentityUser>().HasData(admin, superAdmin);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = adminId,
                RoleId = adminRoleId
            }, new IdentityUserRole<string>
            {
                UserId = superAdminId,
                RoleId = superAdminRoleId
            });
            
        }
    }
}

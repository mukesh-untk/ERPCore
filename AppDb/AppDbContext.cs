using ERPCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPCore.AppDb
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Department> Departments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeDepartment>().HasKey(ed => new { ed.EmployeeId, ed.DepartmentId });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.SeedUsers();
        }
    }
}

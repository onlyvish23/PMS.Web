using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMS.Web.Entities;
using System;

namespace PMS.Web.Data
{
    public class ApplicationDbContext: IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }

    // Class to Seed Test Data for Employees
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    EmployeeId ="e310a6cb-6677-4aa6-93c7-2763956f7a97",
                    FirstName = "David",
                    LastName="Jones",
                    BirthDate=new DateTime(1985,4,4)                    
                },
                new Employee
                {
                    EmployeeId = "r310a6cb-6677-4aa6-93c7-2763956f7a97",
                    FirstName = "John",
                    LastName = "Doe"
                }
            );
        }
    }

    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(
                new AppUser
                {
                    UserName="User123",
                    FirstName = "David",
                    LastName = "Jones",
                    BirthDate = new DateTime(1985, 4, 4)
                },
                new AppUser
                {
                    UserName = "User1234",
                    FirstName = "",
                    LastName = "Doe",
                    BirthDate = new DateTime(1987, 9, 7),
                    RegistrationDate = new DateTime(2018, 10, 10),
                }
            );
        }
    }
}

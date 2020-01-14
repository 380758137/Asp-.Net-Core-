using System;
using System.Collections.Generic;
using Bilibili.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bilibili.Data
{
    public class RoutineDbContext : DbContext
    {
        public RoutineDbContext(DbContextOptions<RoutineDbContext> options) : base(options) { }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().Property(x => x.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Company>().Property(x => x.Introduction).HasMaxLength(500);
            modelBuilder.Entity<Employee>().Property(x => x.EmployeeNo).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<Employee>().Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Employee>().Property(x => x.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Employee>().HasOne(x => x.Company).WithMany(x => x.Employees).HasForeignKey(x => x.CompanyId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = Guid.Parse("f3055f0a-2df1-4f39-8033-c3bd133a15eb"),
                    Name = "Mirstorft",
                    Introduction = "Great Company",
                },
                new Company
                {
                    Id = Guid.Parse("81f2c7e3-f01f-41c1-924d-05bee1bbfa38"),
                    Name = "google",
                    Introduction = "Bad Company",
                },
                new Company
                {
                    Id = Guid.Parse("bb2bde7c-83f4-4cc9-aca0-c260348230cf"),
                    Name = "Alibaba",
                    Introduction = "FuBao Company",
                }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = Guid.Parse("bd345541-4271-47ab-95f4-0e78468de258"),
                    CompanyId = Guid.Parse("f3055f0a-2df1-4f39-8033-c3bd133a15eb"),
                    DateOfBirth = new DateTime(1986, 11, 4),
                    EmployeeNo = "M001",
                    FirstName = "Mary",
                    LastName = "king",
                    Gender = Gender.女
                }, new Employee
                {
                    Id = Guid.Parse("8b00569e-2263-4cf2-aa5f-b14f5de7d90d"),
                    CompanyId = Guid.Parse("f3055f0a-2df1-4f39-8033-c3bd133a15eb"),
                    DateOfBirth = new DateTime(1989, 4, 4),
                    EmployeeNo = "M002",
                    FirstName = "Dave",
                    LastName = "Bob",
                    Gender = Gender.男
                }, new Employee
                {
                    Id = Guid.Parse("7bb9215b-83b5-444a-b96c-13e4a47c8a45"),
                    CompanyId = Guid.Parse("f3055f0a-2df1-4f39-8033-c3bd133a15eb"),
                    DateOfBirth = new DateTime(1960, 11, 4),
                    EmployeeNo = "M003",
                    FirstName = "Keya",
                    LastName = "Noer",
                    Gender = Gender.男
                }, new Employee
                {
                    Id = Guid.Parse("7363e32b-5ff5-4ae0-8c66-66f94ffdfba5"),
                    CompanyId = Guid.Parse("81f2c7e3-f01f-41c1-924d-05bee1bbfa38"),
                    DateOfBirth = new DateTime(1988, 11, 4),
                    EmployeeNo = "G001",
                    FirstName = "Mars",
                    LastName = "Lodfa",
                    Gender = Gender.女
                }, new Employee
                {
                    Id = Guid.Parse("e4d51c62-2f63-4fe1-9570-1ac6cd9e1c5c"),
                    CompanyId = Guid.Parse("81f2c7e3-f01f-41c1-924d-05bee1bbfa38"),
                    DateOfBirth = new DateTime(1990, 4, 4),
                    EmployeeNo = "G002",
                    FirstName = "Nasew",
                    LastName = "Pax",
                    Gender = Gender.男
                }, new Employee
                {
                    Id = Guid.Parse("6aac2b6c-ed10-417e-82af-9b54589e1d28"),
                    CompanyId = Guid.Parse("81f2c7e3-f01f-41c1-924d-05bee1bbfa38"),
                    DateOfBirth = new DateTime(2000, 11, 4),
                    EmployeeNo = "G003",
                    FirstName = "Perter",
                    LastName = "Bumars",
                    Gender = Gender.男
                }, new Employee
                {
                    Id = Guid.Parse("3076aed0-2d87-48b8-9ff1-bd18e9e2d298"),
                    CompanyId = Guid.Parse("bb2bde7c-83f4-4cc9-aca0-c260348230cf"),
                    DateOfBirth = new DateTime(1992, 11, 4),
                    EmployeeNo = "A001",
                    FirstName = "张",
                    LastName = "三",
                    Gender = Gender.女
                }, new Employee
                {
                    Id = Guid.Parse("f718283a-0243-478d-9f26-4a3c0a268eaf"),
                    CompanyId = Guid.Parse("bb2bde7c-83f4-4cc9-aca0-c260348230cf"),
                    DateOfBirth = new DateTime(1990, 4, 4),
                    EmployeeNo = "A002",
                    FirstName = "李",
                    LastName = "四",
                    Gender = Gender.男
                }, new Employee
                {
                    Id = Guid.Parse("86e1a7eb-ec30-482e-bb87-891c7355c8a7"),
                    CompanyId = Guid.Parse("bb2bde7c-83f4-4cc9-aca0-c260348230cf"),
                    DateOfBirth = new DateTime(1999, 11, 4),
                    EmployeeNo = "A003",
                    FirstName = "王",
                    LastName = "五",
                    Gender = Gender.男
                }
            );
        }
    }
}
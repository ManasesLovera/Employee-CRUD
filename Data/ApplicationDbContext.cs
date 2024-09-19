using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using UnidadVI.Models;

namespace UnidadVI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-F6LB3V1;Database=UAPA;Integrated Security=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "John Doe", Age = 28, Salary = 45000.50m, City = "New York" },
                new User { Id = 2, Name = "Jane Smith", Age = 34, Salary = 60000.00m, City = "Los Angeles" },
                new User { Id = 3, Name = "Mike Johnson", Age = 22, Salary = 30000.00m, City = "Chicago" },
                new User { Id = 4, Name = "Emily Davis", Age = 30, Salary = 48000.75m, City = "Houston" },
                new User { Id = 5, Name = "Chris Brown", Age = 40, Salary = 85000.00m, City = "Phoenix" },
                new User { Id = 6, Name = "Anna Lee", Age = 27, Salary = 52000.30m, City = "San Francisco" },
                new User { Id = 7, Name = "David Wilson", Age = 35, Salary = 70000.10m, City = "Miami" },
                new User { Id = 8, Name = "Laura Taylor", Age = 25, Salary = 35000.00m, City = "Seattle" },
                new User { Id = 9, Name = "James White", Age = 33, Salary = 62000.45m, City = "Boston" },
                new User { Id = 10, Name = "Sarah Green", Age = 29, Salary = 46000.50m, City = "Denver" }
            );
        }
    }
}

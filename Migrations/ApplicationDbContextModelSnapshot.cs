﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnidadVI.Data;

#nullable disable

namespace UnidadVI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UnidadVI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 28,
                            City = "New York",
                            Name = "John Doe",
                            Salary = 45000.50m
                        },
                        new
                        {
                            Id = 2,
                            Age = 34,
                            City = "Los Angeles",
                            Name = "Jane Smith",
                            Salary = 60000.00m
                        },
                        new
                        {
                            Id = 3,
                            Age = 22,
                            City = "Chicago",
                            Name = "Mike Johnson",
                            Salary = 30000.00m
                        },
                        new
                        {
                            Id = 4,
                            Age = 30,
                            City = "Houston",
                            Name = "Emily Davis",
                            Salary = 48000.75m
                        },
                        new
                        {
                            Id = 5,
                            Age = 40,
                            City = "Phoenix",
                            Name = "Chris Brown",
                            Salary = 85000.00m
                        },
                        new
                        {
                            Id = 6,
                            Age = 27,
                            City = "San Francisco",
                            Name = "Anna Lee",
                            Salary = 52000.30m
                        },
                        new
                        {
                            Id = 7,
                            Age = 35,
                            City = "Miami",
                            Name = "David Wilson",
                            Salary = 70000.10m
                        },
                        new
                        {
                            Id = 8,
                            Age = 25,
                            City = "Seattle",
                            Name = "Laura Taylor",
                            Salary = 35000.00m
                        },
                        new
                        {
                            Id = 9,
                            Age = 33,
                            City = "Boston",
                            Name = "James White",
                            Salary = 62000.45m
                        },
                        new
                        {
                            Id = 10,
                            Age = 29,
                            City = "Denver",
                            Name = "Sarah Green",
                            Salary = 46000.50m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

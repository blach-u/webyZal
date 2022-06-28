﻿// <auto-generated />
using ProductInventory.Api;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProductInventory.Api.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProductInventory.Api.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "Description 1",
                            Name = "Product 1",
                            Price = 2m,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2L,
                            Description = "Description 2",
                            Name = "Product 2",
                            Price = 4m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 3L,
                            Description = "Description 3",
                            Name = "Product 3",
                            Price = 6m,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Description 4",
                            Name = "Product 4",
                            Price = 8m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 5L,
                            Description = "Description 5",
                            Name = "Product 5",
                            Price = 10m,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 6L,
                            Description = "Description 6",
                            Name = "Product 6",
                            Price = 12m,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 7L,
                            Description = "Description 7",
                            Name = "Product 7",
                            Price = 14m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 8L,
                            Description = "Description 8",
                            Name = "Product 8",
                            Price = 16m,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 9L,
                            Description = "Description 9",
                            Name = "Product 9",
                            Price = 18m,
                            Quantity = 20
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
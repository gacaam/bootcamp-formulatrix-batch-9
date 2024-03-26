﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPITutorial.Data;

#nullable disable

namespace WebAPITutorial.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240326024024_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("WebAPITutorial.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Electronics",
                            Description = "Electronic Items"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Clothes",
                            Description = "Dress Items"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Groceries",
                            Description = "Grocery Items"
                        });
                });

            modelBuilder.Entity("WebAPITutorial.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("money");

                    b.Property<short>("UnitsOnOrder")
                        .HasColumnType("smallint");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Laptop",
                            ProductName = "Laptop",
                            UnitPrice = 0,
                            UnitsOnOrder = (short)0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "Mobile",
                            ProductName = "Mobile",
                            UnitPrice = 0,
                            UnitsOnOrder = (short)0
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "Shirt",
                            ProductName = "Shirt",
                            UnitPrice = 0,
                            UnitsOnOrder = (short)0
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Description = "Jeans",
                            ProductName = "Jeans",
                            UnitPrice = 0,
                            UnitsOnOrder = (short)0
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            Description = "Rice",
                            ProductName = "Rice",
                            UnitPrice = 0,
                            UnitsOnOrder = (short)0
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Description = "Wheat",
                            ProductName = "Wheat",
                            UnitPrice = 0,
                            UnitsOnOrder = (short)0
                        });
                });

            modelBuilder.Entity("WebAPITutorial.Models.Product", b =>
                {
                    b.HasOne("WebAPITutorial.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebAPITutorial.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

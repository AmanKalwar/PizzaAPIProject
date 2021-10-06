﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaAPI.Models;

namespace PizzaAPI.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20211005075400_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaAPI.Models.Pizza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Crust")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Speciality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            ID = 1001,
                            Crust = "Fresh Pan Pizza",
                            Description = "Peppy Paneer Cheese Burst Topped with Extra Cheese",
                            Images = "/Images/pizza1.jfif",
                            Name = "Veg Loaded",
                            Price = 199.0,
                            Speciality = "with Pepsi"
                        },
                        new
                        {
                            ID = 1002,
                            Crust = "Fresh Pan Pizza",
                            Description = "Peppy Paneer Cheese Burst Topped with Extra Cheese",
                            Images = "/Images/pizza2.jfif",
                            Name = "Peppy Paneer Pizza",
                            Price = 299.0,
                            Speciality = "with extra toppings"
                        },
                        new
                        {
                            ID = 1003,
                            Crust = "Fresh Pan Pizza",
                            Description = "Mashroon Topped",
                            Images = "/Images/pizza3.jfif",
                            Name = "Peper Chicken",
                            Price = 199.0,
                            Speciality = "with Pepsi"
                        },
                        new
                        {
                            ID = 1004,
                            Crust = "Fresh Pan Pizza",
                            Description = "Peppy Paneer Cheese Burst Topped with Extra Cheese",
                            Images = "/Images/pizza4.jfif",
                            Name = "Non Veg Loaded",
                            Price = 299.0,
                            Speciality = "with Pepsi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

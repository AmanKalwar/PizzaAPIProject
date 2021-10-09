using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Models
{
    public class PizzaContext:DbContext
    {
        public PizzaContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Pizza>().HasData(
              new Pizza() { ID = 1001, Name = "Veg Loaded", Price = 199, Speciality = "with Pepsi", Crust = "Fresh Pan Pizza", Description = "Peppy Paneer Cheese Burst Topped with Extra Cheese", Images = "/Images/pizza-1.jpg" },
              new Pizza() { ID = 1002, Name = "Peppy Paneer Pizza", Price = 299, Speciality = "with extra toppings", Crust = "Fresh Pan Pizza", Description = "Peppy Paneer Cheese Burst Topped with Extra Cheese", Images = "/Images/pizza-2.jpg" },
              new Pizza() { ID = 1003, Name = "Peper Chicken", Price = 199, Speciality = "with Pepsi", Crust = "Fresh Pan Pizza", Description = "Mashroon Topped", Images = "/Images/pizza-3.jpg" },
              new Pizza() { ID = 1004, Name = "Non Veg Loaded", Price = 299, Speciality = "with Pepsi", Crust = "Fresh Pan Pizza", Description = "Peppy Paneer Cheese Burst Topped with Extra Cheese", Images = "/Images/pizza-4.jpg" }
                );          
        }
    }
}

     
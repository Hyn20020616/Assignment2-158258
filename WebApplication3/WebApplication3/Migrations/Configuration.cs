using System.Web.Security;
using WebApplication3.Models;

namespace WebApplication3.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using WebApplication3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication3.Data.WebApplication3Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication3.Data.WebApplication3Context";
        }

        protected override void Seed(WebApplication3.Data.WebApplication3Context context)
        {
            var categories = new List<Category>
 {
new Category {Name = "Computers and Tablets" },
new Category {Name = "PC Peripherals" },
new Category {Name = "PC Parts" },
new Category {Name = "Networking" },
new Category {Name = "Printing and Office" },
new Category {Name = "Software and Games" },
new Category {Name = "Phones and GPS" },
new Category {Name = "TV Video and Audio" },
new Category {Name = "Cameras and Drones" },
new Category {Name = "Toys and More" },
new Category {Name = "Apple"}
 };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            var products = new List<Product>
 {
new Product {Name = "Lenovo 510", Description = "All in one", Price =
631, CategoryID= categories.Single(c=>c.Name == "Computers and Tablets").ID},
new Product {Name = "ASUS VE248", Description = "LED Gaming Monitor",
Price = 239, CategoryID= categories.Single(c=>c.Name == "PC Peripherals").ID},
new Product {Name = "Samsung S32351", Description = "Full HD LED Monitor", Price = 369, CategoryID= categories.Single(c=>c.Name == "PCPeripherals").ID}, 
new Product {Name = "ASUS Strix GeForce", Description = "GTX1060 Grpahics Card 6GB", Price = 573, CategoryID= categories.Single(c=>c.Name == "PCParts").ID}, 
 new Product {Name = "8Ware USB Blutooth", Description = "V4 Adapter Version", Price = 19.49M, CategoryID= categories.Single(c=>c.Name == 
"Networking").ID}, 
new Product {Name = "Brother Toner", Description = "TN1070 Black 1000 Pages", Price = 60.99M, CategoryID= categories.Single(c=>c.Name == "Printing andOffice").ID}, 
new Product {Name = "Microsoft Home 10", Description = "64 bit", Price 
= 171, CategoryID= categories.Single(c=>c.Name == "Software and Games").ID
    }, 
 new Product {Name = "Microsoft XBox One X", Description = "1 TB", 
Price = 749, CategoryID= categories.Single(c=>c.Name == "TV Video and Audio").ID
}, 
 new Product
 {
     Name = "TP Link NC 450",
     Description = "HD Pan Tilt Wifi Camera", Price = 163.31M, CategoryID= categories.Single(c=>c.Name == "Cameras andDrones").ID}, 
 };
products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
context.SaveChanges(); 
 } 
 } 
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    

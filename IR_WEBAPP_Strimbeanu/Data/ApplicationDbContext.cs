using IR_WEBAPP_Strimbeanu.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IR_WEBAPP_Strimbeanu.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics" },
                new Category { Id = 2, Name = "Books" },
                new Category { Id = 3, Name = "Furniture" }
            );

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", ShortDescription = "Gaming Laptop", LongDescription = "High-performance gaming laptop", ImageUrl = "/images/laptop.jpg", PdfUrl = "/docs/laptop.pdf", CategoryId = 1 },
                new Product { Id = 2, Name = "Smartphone", ShortDescription = "Android Phone", LongDescription = "Latest Android smartphone", ImageUrl = "/images/phone.jpg", PdfUrl = "/docs/phone.pdf", CategoryId = 1 },
                new Product { Id = 3, Name = "Headphones", ShortDescription = "Noise-canceling", LongDescription = "Wireless noise-canceling headphones", ImageUrl = "/images/headphones.jpg", PdfUrl = "/docs/headphones.pdf", CategoryId = 1 },

                new Product { Id = 4, Name = "C# Programming", ShortDescription = "C# Book", LongDescription = "Learn C# from scratch", ImageUrl = "/images/csharp.jpg", PdfUrl = "/docs/csharp.pdf", CategoryId = 2 },
                new Product { Id = 5, Name = "Blazor Guide", ShortDescription = "Blazor Development", LongDescription = "Master Blazor and .NET", ImageUrl = "/images/blazor.jpg", PdfUrl = "/docs/blazor.pdf", CategoryId = 2 },
                new Product { Id = 6, Name = "Software Design Patterns", ShortDescription = "Design Patterns", LongDescription = "Understand software design principles", ImageUrl = "/images/designpatterns.jpg", PdfUrl = "/docs/designpatterns.pdf", CategoryId = 2 },

                new Product { Id = 7, Name = "Office Chair", ShortDescription = "Ergonomic Chair", LongDescription = "Comfortable office chair with lumbar support", ImageUrl = "/images/chair.jpg", PdfUrl = "/docs/chair.pdf", CategoryId = 3 },
                new Product { Id = 8, Name = "Desk", ShortDescription = "Wooden Desk", LongDescription = "Modern wooden office desk", ImageUrl = "/images/desk.jpg", PdfUrl = "/docs/desk.pdf", CategoryId = 3 },
                new Product { Id = 9, Name = "Bookshelf", ShortDescription = "Wooden Shelf", LongDescription = "Spacious bookshelf for organizing books", ImageUrl = "/images/bookshelf.jpg", PdfUrl = "/docs/bookshelf.pdf", CategoryId = 3 },
                new Product { Id = 10, Name = "Table Lamp", ShortDescription = "LED Lamp", LongDescription = "Energy-efficient LED table lamp", ImageUrl = "/images/lamp.jpg", PdfUrl = "/docs/lamp.pdf", CategoryId = 3 }
            );
        }
    }


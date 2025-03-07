using IR_WEBAPP_Strimbeanu.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IR_WEBAPP_Strimbeanu.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }

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
            new Product { Id = 1, Name = "Laptop Apple MacBook Air 13-inch", ShortDescription = "Laptop Apple MacBook", LongDescription = "High-performance Laptop Apple MacBook", ThumbnailUrl = "/images/laptop1.jpg", PdfUrl = "/docs/laptop.pdf", CategoryId = 1 },
            new Product { Id = 2, Name = "Smartphone", ShortDescription = "Android Phone", LongDescription = "Latest Android smartphone", ThumbnailUrl = "/images/phone1.jpg", PdfUrl = "/docs/phone.pdf", CategoryId = 1 },
            new Product { Id = 3, Name = "Headphones", ShortDescription = "Noise-canceling", LongDescription = "Wireless noise-canceling headphones", ThumbnailUrl = "/images/headphones1.jpg", PdfUrl = "/docs/headphones.pdf", CategoryId = 1 },

            new Product { Id = 4, Name = "C# Programming", ShortDescription = "C# Book", LongDescription = "Learn C# from scratch", ThumbnailUrl = "/images/csharp1.jpg", PdfUrl = "/docs/csharp.pdf", CategoryId = 2 },
            new Product { Id = 5, Name = "Blazor Guide", ShortDescription = "Blazor Development", LongDescription = "Master Blazor and .NET", ThumbnailUrl = "/images/blazor1.jpg", PdfUrl = "/docs/blazor.pdf", CategoryId = 2 },
            new Product { Id = 6, Name = "Software Design Patterns", ShortDescription = "Design Patterns", LongDescription = "Understand software design principles", ThumbnailUrl = "/images/designpatterns1.jpg", PdfUrl = "/docs/designpatterns.pdf", CategoryId = 2 },

            new Product { Id = 7, Name = "Office Chair", ShortDescription = "Ergonomic Chair", LongDescription = "Comfortable office chair with lumbar support", ThumbnailUrl = "/images/chair1.jpg", PdfUrl = "/docs/chair.pdf", CategoryId = 3 },
            new Product { Id = 8, Name = "Desk", ShortDescription = "Wooden Desk", LongDescription = "Modern wooden office desk", ThumbnailUrl = "/images/desk1.jpg", PdfUrl = "/docs/desk.pdf", CategoryId = 3 },
            new Product { Id = 9, Name = "Bookshelf", ShortDescription = "Wooden Shelf", LongDescription = "Spacious bookshelf for organizing books", ThumbnailUrl = "/images/bookshelf1.jpg", PdfUrl = "/docs/bookshelf.pdf", CategoryId = 3 },
            new Product { Id = 10, Name = "Table Lamp", ShortDescription = "LED Lamp", LongDescription = "Energy-efficient LED table lamp", ThumbnailUrl = "/images/lamp1.jpg", PdfUrl = "/docs/lamp.pdf", CategoryId = 3 }
        );

        // Seed Product Images (Each product gets multiple images)
        modelBuilder.Entity<ProductImage>().HasData(
            new ProductImage { Id = 1, ProductId = 1, ImageUrl = "/images/laptop1.jpg" },
            new ProductImage { Id = 2, ProductId = 1, ImageUrl = "/images/laptop2.jpg" },

            new ProductImage { Id = 3, ProductId = 2, ImageUrl = "/images/phone1.avif" },
            new ProductImage { Id = 4, ProductId = 2, ImageUrl = "/images/phone2.jpg" },

            new ProductImage { Id = 5, ProductId = 3, ImageUrl = "/images/headphones1.jpg" },
            new ProductImage { Id = 6, ProductId = 3, ImageUrl = "/images/headphones2.jpg" },

            new ProductImage { Id = 7, ProductId = 4, ImageUrl = "/images/csharp1.jpg" },
            new ProductImage { Id = 8, ProductId = 4, ImageUrl = "/images/csharp2.jpg" },

            new ProductImage { Id = 9, ProductId = 5, ImageUrl = "/images/blazor1.jpg" },
            new ProductImage { Id = 10, ProductId = 5, ImageUrl = "/images/blazor2.jpg" },

            new ProductImage { Id = 11, ProductId = 6, ImageUrl = "/images/designpatterns1.jpg" },
            new ProductImage { Id = 12, ProductId = 6, ImageUrl = "/images/designpatterns2.jpg" },

            new ProductImage { Id = 13, ProductId = 7, ImageUrl = "/images/chair1.jpg" },
            new ProductImage { Id = 14, ProductId = 7, ImageUrl = "/images/chair2.jpg" },

            new ProductImage { Id = 15, ProductId = 8, ImageUrl = "/images/desk1.jpg" },
            new ProductImage { Id = 16, ProductId = 8, ImageUrl = "/images/desk2.jpg" },

            new ProductImage { Id = 17, ProductId = 9, ImageUrl = "/images/bookshelf1.jpg" },
            new ProductImage { Id = 18, ProductId = 9, ImageUrl = "/images/bookshelf2.jpg" },

            new ProductImage { Id = 19, ProductId = 10, ImageUrl = "/images/lamp1.jpg" },
            new ProductImage { Id = 20, ProductId = 10, ImageUrl = "/images/lamp2.jpg" }
        );
    }
}

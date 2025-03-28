using IR_WEBAPP_Strimbeanu.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IR_WEBAPP_Strimbeanu.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartItem> CartItems { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<ProductTag> ProductTags { get; set; }
    public DbSet<Wishlist> Wishlists { get; set; }
    public DbSet<WishlistItem> WishlistItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ProductTag>()
            .HasKey(pt => new { pt.ProductId, pt.TagId });

        modelBuilder.Entity<ProductTag>()
            .HasOne(pt => pt.Product)
            .WithMany(p => p.Tags)
            .HasForeignKey(pt => pt.ProductId);

        modelBuilder.Entity<ProductTag>()
            .HasOne(pt => pt.Tag)
            .WithMany(t => t.ProductTags)
            .HasForeignKey(pt => pt.TagId);

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Books" },
            new Category { Id = 3, Name = "Furniture" }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Laptop Apple MacBook Air 13-inch", ShortDescription = "Laptop Apple MacBook", LongDescription = "High-performance Laptop Apple MacBook", ThumbnailUrl = "/images/laptop1.jpg", PdfUrl = "/docs/laptop.pdf", CategoryId = 1, Price = 6499.99m, Stock = 12, UnitsSold = 50 },
            new Product { Id = 2, Name = "Smartphone", ShortDescription = "Android Phone", LongDescription = "Latest Android smartphone", ThumbnailUrl = "/images/phone1.jpg", PdfUrl = "/docs/phone.pdf", CategoryId = 1, Price = 2999.50m, Stock = 35, UnitsSold = 120 },
            new Product { Id = 3, Name = "Headphones", ShortDescription = "Noise-canceling", LongDescription = "Wireless noise-canceling headphones", ThumbnailUrl = "/images/headphones1.jpg", PdfUrl = "/docs/headphones.pdf", CategoryId = 1, Price = 499.99m, Stock = 20, UnitsSold = 75 },
            new Product { Id = 4, Name = "C# Programming", ShortDescription = "C# Book", LongDescription = "Learn C# from scratch", ThumbnailUrl = "/images/csharp1.jpg", PdfUrl = "/docs/csharp.pdf", CategoryId = 2, Price = 149.99m, Stock = 80, UnitsSold = 40 },
            new Product { Id = 5, Name = "Blazor Guide", ShortDescription = "Blazor Development", LongDescription = "Master Blazor and .NET", ThumbnailUrl = "/images/blazor1.jpg", PdfUrl = "/docs/blazor.pdf", CategoryId = 2, Price = 199.99m, Stock = 50, UnitsSold = 65 },
            new Product { Id = 6, Name = "Software Design Patterns", ShortDescription = "Design Patterns", LongDescription = "Understand software design principles", ThumbnailUrl = "/images/designpatterns1.jpg", PdfUrl = "/docs/designpatterns.pdf", CategoryId = 2, Price = 169.00m, Stock = 40, UnitsSold = 58 },
            new Product { Id = 7, Name = "Office Chair", ShortDescription = "Ergonomic Chair", LongDescription = "Comfortable office chair with lumbar support", ThumbnailUrl = "/images/chair1.jpg", PdfUrl = "/docs/chair.pdf", CategoryId = 3, Price = 899.99m, Stock = 18, UnitsSold = 34 },
            new Product { Id = 8, Name = "Desk", ShortDescription = "Wooden Desk", LongDescription = "Modern wooden office desk", ThumbnailUrl = "/images/desk1.jpg", PdfUrl = "/docs/desk.pdf", CategoryId = 3, Price = 1149.99m, Stock = 15, UnitsSold = 22 },
            new Product { Id = 9, Name = "Bookshelf", ShortDescription = "Wooden Shelf", LongDescription = "Spacious bookshelf for organizing books", ThumbnailUrl = "/images/bookshelf1.jpg", PdfUrl = "/docs/bookshelf.pdf", CategoryId = 3, Price = 599.50m, Stock = 25, UnitsSold = 38 },
            new Product { Id = 10, Name = "Table Lamp", ShortDescription = "LED Lamp", LongDescription = "Energy-efficient LED table lamp", ThumbnailUrl = "/images/lamp1.jpg", PdfUrl = "/docs/lamp.pdf", CategoryId = 3, Price = 149.00m, Stock = 60, UnitsSold = 55 }
        );

        modelBuilder.Entity<Tag>().HasData(
            new Tag { Id = 1, Name = "Bestseller" },
            new Tag { Id = 2, Name = "Eco-Friendly" },
            new Tag { Id = 3, Name = "Budget" },
            new Tag { Id = 4, Name = "Premium" },
            new Tag { Id = 5, Name = "Trending" }
        );

        modelBuilder.Entity<ProductTag>().HasData(
            new ProductTag { ProductId = 1, TagId = 4 },
            new ProductTag { ProductId = 1, TagId = 1 },
            new ProductTag { ProductId = 2, TagId = 5 },
            new ProductTag { ProductId = 3, TagId = 3 },
            new ProductTag { ProductId = 4, TagId = 1 },
            new ProductTag { ProductId = 5, TagId = 2 },
            new ProductTag { ProductId = 6, TagId = 3 },
            new ProductTag { ProductId = 7, TagId = 1 },
            new ProductTag { ProductId = 8, TagId = 2 },
            new ProductTag { ProductId = 9, TagId = 5 },
            new ProductTag { ProductId = 10, TagId = 4 }
        );

        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "user-1",
                UserName = "user1@test.com",
                NormalizedUserName = "USER1@TEST.COM",
                Email = "user1@test.com",
                NormalizedEmail = "USER1@TEST.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "P@ssword1!")
            },
            new ApplicationUser
            {
                Id = "user-2",
                UserName = "user2@test.com",
                NormalizedUserName = "USER2@TEST.COM",
                Email = "user2@test.com",
                NormalizedEmail = "USER2@TEST.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "P@ssword1!")
            },
            new ApplicationUser
            {
                Id = "user-3",
                UserName = "user3@test.com",
                NormalizedUserName = "USER3@TEST.COM",
                Email = "user3@test.com",
                NormalizedEmail = "USER3@TEST.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "P@ssword1!")
            },
            new ApplicationUser
            {
                Id = "user-4",
                UserName = "user4@test.com",
                NormalizedUserName = "USER4@TEST.COM",
                Email = "user4@test.com",
                NormalizedEmail = "USER4@TEST.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "P@ssword1!")
            },
            new ApplicationUser
            {
                Id = "user-5",
                UserName = "user5@test.com",
                NormalizedUserName = "USER5@TEST.COM",
                Email = "user5@test.com",
                NormalizedEmail = "USER5@TEST.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "P@ssword1!")
            }
        );



        modelBuilder.Entity<Review>().HasData(
            new Review { Id = 1, ProductId = 2, UserId = "user-5", Rating = 5, Comment = "Great product! Review #1", CreatedAt = DateTime.Parse("2025-02-01") },
            new Review { Id = 2, ProductId = 2, UserId = "user-3", Rating = 4, Comment = "Great product! Review #2", CreatedAt = DateTime.Parse("2025-01-14") },
            new Review { Id = 3, ProductId = 4, UserId = "user-3", Rating = 4, Comment = "Great product! Review #3", CreatedAt = DateTime.Parse("2024-04-22") },
            new Review { Id = 4, ProductId = 1, UserId = "user-4", Rating = 5, Comment = "Great product! Review #4", CreatedAt = DateTime.Parse("2024-09-04") },
            new Review { Id = 5, ProductId = 5, UserId = "user-2", Rating = 4, Comment = "Great product! Review #5", CreatedAt = DateTime.Parse("2025-02-02") },
            new Review { Id = 6, ProductId = 2, UserId = "user-5", Rating = 4, Comment = "Great product! Review #6", CreatedAt = DateTime.Parse("2024-06-10") },
            new Review { Id = 7, ProductId = 5, UserId = "user-1", Rating = 5, Comment = "Great product! Review #7", CreatedAt = DateTime.Parse("2024-12-19") },
            new Review { Id = 8, ProductId = 3, UserId = "user-1", Rating = 5, Comment = "Great product! Review #8", CreatedAt = DateTime.Parse("2024-11-10") },
            new Review { Id = 9, ProductId = 5, UserId = "user-1", Rating = 4, Comment = "Great product! Review #9", CreatedAt = DateTime.Parse("2024-09-12") },
            new Review { Id = 10, ProductId = 5, UserId = "user-2", Rating = 3, Comment = "Great product! Review #10", CreatedAt = DateTime.Parse("2025-01-17") },
            new Review { Id = 11, ProductId = 2, UserId = "user-4", Rating = 4, Comment = "Great product! Review #11", CreatedAt = DateTime.Parse("2025-01-26") },
            new Review { Id = 12, ProductId = 3, UserId = "user-5", Rating = 4, Comment = "Great product! Review #12", CreatedAt = DateTime.Parse("2025-02-22") },
            new Review { Id = 13, ProductId = 3, UserId = "user-3", Rating = 5, Comment = "Great product! Review #13", CreatedAt = DateTime.Parse("2024-08-23") },
            new Review { Id = 14, ProductId = 5, UserId = "user-3", Rating = 3, Comment = "Great product! Review #14", CreatedAt = DateTime.Parse("2025-02-10") },
            new Review { Id = 15, ProductId = 4, UserId = "user-5", Rating = 3, Comment = "Great product! Review #15", CreatedAt = DateTime.Parse("2025-02-22") },
            new Review { Id = 16, ProductId = 4, UserId = "user-5", Rating = 3, Comment = "Great product! Review #16", CreatedAt = DateTime.Parse("2025-02-07") },
            new Review { Id = 17, ProductId = 4, UserId = "user-3", Rating = 3, Comment = "Great product! Review #17", CreatedAt = DateTime.Parse("2024-04-22") },
            new Review { Id = 18, ProductId = 1, UserId = "user-2", Rating = 5, Comment = "Great product! Review #18", CreatedAt = DateTime.Parse("2024-09-12") },
            new Review { Id = 19, ProductId = 2, UserId = "user-2", Rating = 5, Comment = "Great product! Review #19", CreatedAt = DateTime.Parse("2025-02-08") },
            new Review { Id = 20, ProductId = 2, UserId = "user-3", Rating = 5, Comment = "Great product! Review #20", CreatedAt = DateTime.Parse("2024-05-13") }
        );
    }
}

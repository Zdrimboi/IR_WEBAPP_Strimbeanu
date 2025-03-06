﻿// <auto-generated />
using IR_WEBAPP_Strimbeanu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IR_WEBAPP_Strimbeanu.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250306174957_mig2")]
    partial class mig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IR_WEBAPP_Strimbeanu.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Furniture"
                        });
                });

            modelBuilder.Entity("IR_WEBAPP_Strimbeanu.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PdfUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ImageUrl = "/images/laptop.jpg",
                            LongDescription = "High-performance gaming laptop",
                            Name = "Laptop",
                            PdfUrl = "/docs/laptop.pdf",
                            ShortDescription = "Gaming Laptop"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ImageUrl = "/images/phone.jpg",
                            LongDescription = "Latest Android smartphone",
                            Name = "Smartphone",
                            PdfUrl = "/docs/phone.pdf",
                            ShortDescription = "Android Phone"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            ImageUrl = "/images/headphones.jpg",
                            LongDescription = "Wireless noise-canceling headphones",
                            Name = "Headphones",
                            PdfUrl = "/docs/headphones.pdf",
                            ShortDescription = "Noise-canceling"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            ImageUrl = "/images/csharp.jpg",
                            LongDescription = "Learn C# from scratch",
                            Name = "C# Programming",
                            PdfUrl = "/docs/csharp.pdf",
                            ShortDescription = "C# Book"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            ImageUrl = "/images/blazor.jpg",
                            LongDescription = "Master Blazor and .NET",
                            Name = "Blazor Guide",
                            PdfUrl = "/docs/blazor.pdf",
                            ShortDescription = "Blazor Development"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            ImageUrl = "/images/designpatterns.jpg",
                            LongDescription = "Understand software design principles",
                            Name = "Software Design Patterns",
                            PdfUrl = "/docs/designpatterns.pdf",
                            ShortDescription = "Design Patterns"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            ImageUrl = "/images/chair.jpg",
                            LongDescription = "Comfortable office chair with lumbar support",
                            Name = "Office Chair",
                            PdfUrl = "/docs/chair.pdf",
                            ShortDescription = "Ergonomic Chair"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            ImageUrl = "/images/desk.jpg",
                            LongDescription = "Modern wooden office desk",
                            Name = "Desk",
                            PdfUrl = "/docs/desk.pdf",
                            ShortDescription = "Wooden Desk"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            ImageUrl = "/images/bookshelf.jpg",
                            LongDescription = "Spacious bookshelf for organizing books",
                            Name = "Bookshelf",
                            PdfUrl = "/docs/bookshelf.pdf",
                            ShortDescription = "Wooden Shelf"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            ImageUrl = "/images/lamp.jpg",
                            LongDescription = "Energy-efficient LED table lamp",
                            Name = "Table Lamp",
                            PdfUrl = "/docs/lamp.pdf",
                            ShortDescription = "LED Lamp"
                        });
                });

            modelBuilder.Entity("IR_WEBAPP_Strimbeanu.Models.Product", b =>
                {
                    b.HasOne("IR_WEBAPP_Strimbeanu.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("IR_WEBAPP_Strimbeanu.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

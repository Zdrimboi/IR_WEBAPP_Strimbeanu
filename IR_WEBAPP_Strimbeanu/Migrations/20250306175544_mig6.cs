using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IR_WEBAPP_Strimbeanu.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Books" },
                    { 3, "Furniture" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImageUrl", "LongDescription", "Name", "PdfUrl", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "/images/laptop.jpg", "High-performance gaming laptop", "Laptop", "/docs/laptop.pdf", "Gaming Laptop" },
                    { 2, 1, "/images/phone.jpg", "Latest Android smartphone", "Smartphone", "/docs/phone.pdf", "Android Phone" },
                    { 3, 1, "/images/headphones.jpg", "Wireless noise-canceling headphones", "Headphones", "/docs/headphones.pdf", "Noise-canceling" },
                    { 4, 2, "/images/csharp.jpg", "Learn C# from scratch", "C# Programming", "/docs/csharp.pdf", "C# Book" },
                    { 5, 2, "/images/blazor.jpg", "Master Blazor and .NET", "Blazor Guide", "/docs/blazor.pdf", "Blazor Development" },
                    { 6, 2, "/images/designpatterns.jpg", "Understand software design principles", "Software Design Patterns", "/docs/designpatterns.pdf", "Design Patterns" },
                    { 7, 3, "/images/chair.jpg", "Comfortable office chair with lumbar support", "Office Chair", "/docs/chair.pdf", "Ergonomic Chair" },
                    { 8, 3, "/images/desk.jpg", "Modern wooden office desk", "Desk", "/docs/desk.pdf", "Wooden Desk" },
                    { 9, 3, "/images/bookshelf.jpg", "Spacious bookshelf for organizing books", "Bookshelf", "/docs/bookshelf.pdf", "Wooden Shelf" },
                    { 10, 3, "/images/lamp.jpg", "Energy-efficient LED table lamp", "Table Lamp", "/docs/lamp.pdf", "LED Lamp" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

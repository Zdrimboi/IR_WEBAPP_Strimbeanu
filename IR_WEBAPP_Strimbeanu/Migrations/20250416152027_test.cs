using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IR_WEBAPP_Strimbeanu.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54b335db-d3e5-43a5-9ee8-fd8319e45301", "AQAAAAIAAYagAAAAEOrcY3nHUTjilOfiYEj0AiJJr31aLJMb6G4w0hsvFhP2c5FNFOekNgo4/IsvmLRzsA==", "05f3f1fa-01f2-4fdf-ac3f-970e351ef178" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49011f63-5c4d-48d9-a80d-a2c1cabe9974", "AQAAAAIAAYagAAAAEFNCNDfxMUKb20iHYtLWZ6j8Ztws89KqOv+waBfSaibrN2Z2EYUROqtXowArQrJDjg==", "4b90c5c5-6e2e-4205-8667-0d0bf1e6621c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc2606a3-595e-4edb-8b19-5dc9f1c1bf9d", "AQAAAAIAAYagAAAAEEdMfSWVNy9uizZyAiLZarGc74w+ag03c3xEBQ32cGBHAZ3anEQNs46oOXZ/tWchhQ==", "d5493a79-170d-4666-ac23-88d0540a75fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44037326-5e63-460f-8a1b-990cb992ef8c", "AQAAAAIAAYagAAAAEKBu+uWOHUEnTWkZfaZ6mf5UWGzdTTBsvNIMmIxmf7X4oADC/6yJpJFnMtT87CPg8A==", "e686d27b-aa3b-47e2-980a-004f32f55274" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7329785-1027-4533-b9dd-4eafcde83294", "AQAAAAIAAYagAAAAEDzikw86XoQsLNg//NqqWFfEI+ROs57Tm9EhYfUm0n3O5u7HroR3BQUHriT0GhCPqw==", "6f49cd4c-2eaa-43b2-9d8e-e983b9bb1cf3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PdfUrl",
                value: "/docs/Factsheet - 13-inch MacBook Pro.pdf");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "PdfUrl",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f56e9cf-da16-4822-bda4-d18e7fdcabaf", "AQAAAAIAAYagAAAAEOWFXTIik1MxcXpheACj9YPZwNl1NK+jpQGV94RMOYpsf0zOeeHvexKsRjXgv6hXZQ==", "3e5ed6c6-d044-454e-960f-2b24a091d53e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e9121be-cac5-4f31-b531-918334510cb2", "AQAAAAIAAYagAAAAEJudYEgfStKwaNASOJ+yy6zOo04ahgY/tmnceQsSf2P/1BomqATP+pLfKA9NBAE22g==", "51eb6e91-f242-4b65-a359-2661ff080f56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b8c90c5-e126-4372-a8dd-92dcd79aa19f", "AQAAAAIAAYagAAAAENfQdkW0i1TintngBd3+/PtQijJ+YjJQNgXZzJr8JnlTrHVCyHq/coEQ16Nz9odSDQ==", "88f00d0e-2e0a-484d-9dc6-7eea3ef461cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f793526-cf67-4b5b-a5c1-067621985ed3", "AQAAAAIAAYagAAAAEMBNtFIpSVOqG5e7Unitj/KyZ4U47/JP3y5M6rG8BEwUTvFPd8GjyVFdihwvnDAihA==", "08ede835-a458-460c-8638-72fe3d6ec1c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2b0650d-0a9a-408d-81ef-fe8ccc317e00", "AQAAAAIAAYagAAAAEFAjEPhbd1CpQVakqGJS0SrWY7rbMc2z2ywYfvo8yhrfwxQ9etw8s7W4IR8xfcDUAg==", "9ae1ff4e-65a9-4f45-8803-ee091ec616ff" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PdfUrl",
                value: "/docs/laptop.pdf");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "PdfUrl",
                value: "/docs/phone.pdf");
        }
    }
}

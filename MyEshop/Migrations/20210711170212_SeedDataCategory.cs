using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEshop.Migrations
{
    public partial class SeedDataCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "لباس زنانه", "لباس زنانه" },
                    { 2, "لباس مردانه", "لباس مردانه" },
                    { 3, "لباس پسرانه", "لباس پسرانه" },
                    { 4, "لباس دخترانه", "لباس دخترانه" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

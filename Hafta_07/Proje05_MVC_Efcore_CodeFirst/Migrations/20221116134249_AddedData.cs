using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje05_MVC_Efcore_CodeFirst.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 1, "phones", "Phone" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 2, "Tablets", "Tablet" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Desc", "Name" },
                values: new object[] { 3, "Computers", "Computer" });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 34, "İstnabul" });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 35, "İzmir" });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 53, "Rize" });

            migrationBuilder.InsertData(
                table: "Citys",
                columns: new[] { "Id", "Name" },
                values: new object[] { 77, "Yalova" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Desc", "Name", "Price" },
                values: new object[] { 1, 1, "phones", "iphone", 15000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Desc", "Name", "Price" },
                values: new object[] { 2, 3, "pc", "Dell", 12000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Desc", "Name", "Price" },
                values: new object[] { 3, 1, "phones", "Samsung", 15000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Desc", "Name", "Price" },
                values: new object[] { 4, 2, "tablet", "Piranha", 1000m });
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
                table: "Citys",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Citys",
                keyColumn: "Id",
                keyValue: 77);

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

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");
        }
    }
}

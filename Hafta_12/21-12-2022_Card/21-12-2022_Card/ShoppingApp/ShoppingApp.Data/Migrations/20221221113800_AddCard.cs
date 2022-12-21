using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f773cb28-29fa-465f-adcf-ef5533f1d653", "10278c4f-11b4-4ef1-9881-566f34aa4372" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8772563d-45a6-4abc-b7bc-81f91528d945", "185cd080-02b1-469d-b307-2db895f98d34" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8772563d-45a6-4abc-b7bc-81f91528d945");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f773cb28-29fa-465f-adcf-ef5533f1d653");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10278c4f-11b4-4ef1-9881-566f34aa4372");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "185cd080-02b1-469d-b307-2db895f98d34");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "795b8f65-1876-49d9-b38f-d48e9ff717a0", null, "Admin Rolü", "Admin", "ADMIN" },
                    { "c6afb3d8-d27a-44e5-afe6-f123832db4d3", null, "User Rolü", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b39b4f21-c2be-4fe0-bc10-811f25eeb484", 0, "4ab1cb0d-38ef-4b4b-838c-149dc7e7ae40", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEA11WHGzIZnjnVXkgeTfJn1/KRhe6IEwLc5cLKIayFxs3XYfia3vlMF1OTjuy75pdA==", null, false, "946dd58c-167b-4956-a67e-22ebbd6ccc62", false, "user" },
                    { "b83c3a75-7daf-41de-9bd8-b13157f0090c", 0, "e3e42fa7-1fd7-45d8-a70f-bd5663833f48", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEEDLRgghHgjTZ4+eR3122lt9+DhHCqhqANJRLCDV9tODEpXrrevUZn0Tw/nZmWdVTQ==", null, false, "cfd46180-73ba-4a21-a9b5-a042f468276d", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c6afb3d8-d27a-44e5-afe6-f123832db4d3", "b39b4f21-c2be-4fe0-bc10-811f25eeb484" },
                    { "795b8f65-1876-49d9-b38f-d48e9ff717a0", "b83c3a75-7daf-41de-9bd8-b13157f0090c" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, "b83c3a75-7daf-41de-9bd8-b13157f0090c" },
                    { 2, "b39b4f21-c2be-4fe0-bc10-811f25eeb484" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c6afb3d8-d27a-44e5-afe6-f123832db4d3", "b39b4f21-c2be-4fe0-bc10-811f25eeb484" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "795b8f65-1876-49d9-b38f-d48e9ff717a0", "b83c3a75-7daf-41de-9bd8-b13157f0090c" });

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "795b8f65-1876-49d9-b38f-d48e9ff717a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6afb3d8-d27a-44e5-afe6-f123832db4d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b39b4f21-c2be-4fe0-bc10-811f25eeb484");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b83c3a75-7daf-41de-9bd8-b13157f0090c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8772563d-45a6-4abc-b7bc-81f91528d945", null, "User Rolü", "User", "USER" },
                    { "f773cb28-29fa-465f-adcf-ef5533f1d653", null, "Admin Rolü", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10278c4f-11b4-4ef1-9881-566f34aa4372", 0, "df0de553-0f65-4292-b515-e58336d16cbf", new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "Deniz", "Kadın", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEGpHJ1f49IKq2JiaJVrMB6Vcisuww16ZkUnaD6k8mOy4BeiNyUVp3rfozS2xdW2evw==", null, false, "3908e231-2fa0-4c14-9ab8-64faa7eca4c7", false, "admin" },
                    { "185cd080-02b1-469d-b307-2db895f98d34", 0, "7b906265-c6d5-43fb-bcfa-ec12f3a54395", new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "Kemal", "Erkek", "User", false, null, "USER@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEMDwChR3I1kL4VXQKHG+GebpIars4PVpY2lG42V3TkrIDgCDZsOXZh0TiWkVDVAxbQ==", null, false, "da622f04-c77b-456c-9825-ea27398a3bc5", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f773cb28-29fa-465f-adcf-ef5533f1d653", "10278c4f-11b4-4ef1-9881-566f34aa4372" },
                    { "8772563d-45a6-4abc-b7bc-81f91528d945", "185cd080-02b1-469d-b307-2db895f98d34" }
                });
        }
    }
}

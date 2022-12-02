using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e182c458-b16f-49f9-9878-c0febb971c4a");

            migrationBuilder.DropColumn(
                name: "IdNovi",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1cafc0f7-687b-488b-a095-b11e6d85c305", "3049c3aa-590a-4f0e-abda-d095d3a9302b", "Admin", "ADMIN" },
                    { "423e83a1-e8ca-46fe-9814-23c1f46dde89", "17e03696-55c8-4225-ba2f-8c71a65fc557", "Korisnik", "KORISNIK" },
                    { "d5e999a1-8bef-42e6-b174-b4a4f1d98c28", "bceec25b-6e6c-4ccc-bbb6-47229b5fc053", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5564392-4bd9-4b2d-a7be-5fc74715096b", 0, "Mahala", "123", "b1d39260-f973-4110-b7ef-85fbc268f011", new DateTime(2022, 11, 22, 11, 29, 31, 552, DateTimeKind.Local).AddTicks(6049), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "2bb68c50-ad85-45ff-8050-8667b6269cc6", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cafc0f7-687b-488b-a095-b11e6d85c305");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e83a1-e8ca-46fe-9814-23c1f46dde89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5e999a1-8bef-42e6-b174-b4a4f1d98c28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5564392-4bd9-4b2d-a7be-5fc74715096b");

            migrationBuilder.AddColumn<string>(
                name: "IdNovi",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "IdNovi", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e182c458-b16f-49f9-9878-c0febb971c4a", 0, "Mahala", "123", "17dec392-434e-4e58-b483-0f6d8bd3ff04", new DateTime(2022, 11, 22, 11, 6, 6, 857, DateTimeKind.Local).AddTicks(6325), 2, "salem@seminarski.com", false, "Mostar", "ed21b23e-46cf-45e6-b767-6e48ec8f3c51", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "f1c4843d-2e08-4d31-a336-64676ea8a2e8", 2, false, null });
        }
    }
}

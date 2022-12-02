using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class novi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c79ddf09-ec87-4fb0-abec-821878355e7e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "IdNovi", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e182c458-b16f-49f9-9878-c0febb971c4a", 0, "Mahala", "123", "17dec392-434e-4e58-b483-0f6d8bd3ff04", new DateTime(2022, 11, 22, 11, 6, 6, 857, DateTimeKind.Local).AddTicks(6325), 2, "salem@seminarski.com", false, "Mostar", "ed21b23e-46cf-45e6-b767-6e48ec8f3c51", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "f1c4843d-2e08-4d31-a336-64676ea8a2e8", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e182c458-b16f-49f9-9878-c0febb971c4a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "IdNovi", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c79ddf09-ec87-4fb0-abec-821878355e7e", 0, "Mahala", "123", "de976e5d-519e-4351-b207-297cbbb6888c", new DateTime(2022, 11, 16, 21, 56, 2, 140, DateTimeKind.Local).AddTicks(6810), 2, "salem@seminarski.com", false, "Mostar", "bc01f1a0-f212-4302-ab30-9fb60b433b3c", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "4b0b34a2-e404-40de-863b-ab6fbd3659d8", 2, false, null });
        }
    }
}

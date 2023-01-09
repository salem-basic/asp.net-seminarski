using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class recenzijaKorisnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47ac1635-b0ab-4aef-bb53-8ca972b684df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "480739f5-3567-4617-a704-c069de6a0a02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0b8fe6a-f369-497d-a405-8ffc4733e0a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0d4bac8-4578-42c4-b24b-ee6aad8baad5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d900584-bb4f-4a28-a0f5-c9cee334e396", "a1e8b6b4-a137-4822-99c6-b9aa81b6daa2", "Zaposlenik", "ZAPOSLENIK" },
                    { "22b7dc55-3670-48c8-8a7b-56ef30a1704a", "8de9d39b-af49-412b-8565-17a46e744590", "Admin", "ADMIN" },
                    { "67e71521-5367-4ff7-a0b4-1a28452ded96", "1fe74b78-3494-4e11-885d-8d981af2f3df", "Korisnik", "KORISNIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f693e189-1779-4a1d-ae65-2dcb29a9c8e3", 0, "Mahala", "123", "2b62d925-cd32-4891-a4f9-7185e95cb986", new DateTime(2023, 1, 7, 20, 17, 20, 964, DateTimeKind.Local).AddTicks(2552), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "459f0c8a-5b58-49e2-9ff7-b7ace068a523", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d900584-bb4f-4a28-a0f5-c9cee334e396");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22b7dc55-3670-48c8-8a7b-56ef30a1704a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67e71521-5367-4ff7-a0b4-1a28452ded96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f693e189-1779-4a1d-ae65-2dcb29a9c8e3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47ac1635-b0ab-4aef-bb53-8ca972b684df", "d8cefe27-3735-4d33-b078-62e8204690fe", "Admin", "ADMIN" },
                    { "480739f5-3567-4617-a704-c069de6a0a02", "5512167f-41f3-48f3-919e-2b11217e3035", "Korisnik", "KORISNIK" },
                    { "f0b8fe6a-f369-497d-a405-8ffc4733e0a3", "57409c3f-073e-4c4d-a427-959da908e76e", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c0d4bac8-4578-42c4-b24b-ee6aad8baad5", 0, "Mahala", "123", "a1902ddc-0420-4b89-895a-88276bb4fcc3", new DateTime(2023, 1, 7, 19, 45, 23, 574, DateTimeKind.Local).AddTicks(7398), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "f69c240f-d473-4972-8830-4e8975b54db7", 2, false, null });
        }
    }
}

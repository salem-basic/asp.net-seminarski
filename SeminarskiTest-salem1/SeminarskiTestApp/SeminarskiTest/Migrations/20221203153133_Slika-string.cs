using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class Slikastring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16a3dff7-8d1b-4f7f-9634-7eec7228a874");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96cf9f2b-2d77-411c-b4bc-efa64b03985b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ae77795-bc74-462c-9a21-97a9cde2df7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c0b57ba-7490-4a4c-b110-56c4344566ed");

            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "Proizvod",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a199705-3c17-44db-b97d-4b3669b5505a", "ce56bb5e-d549-4cac-9cf8-e79f87449591", "Korisnik", "KORISNIK" },
                    { "2ffe1470-0bb9-4cf4-a65b-0a4bbc0b97b4", "38fbab01-c24c-4e48-9793-0d2a5f3bea32", "Zaposlenik", "ZAPOSLENIK" },
                    { "e64b5be5-624e-4863-ab08-d804ce3f5594", "b88295cf-d896-4558-87d6-e5df0310c2f4", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "51ccf8d8-83d2-4dcc-aa84-1a77ba040d50", 0, "Mahala", "123", "1eaa5d60-7ebe-42dd-a787-4b8663d0ae56", new DateTime(2022, 12, 3, 16, 31, 32, 555, DateTimeKind.Local).AddTicks(26), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "7fd038c2-92c4-42c7-9dde-de5b3bb4de17", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a199705-3c17-44db-b97d-4b3669b5505a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ffe1470-0bb9-4cf4-a65b-0a4bbc0b97b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e64b5be5-624e-4863-ab08-d804ce3f5594");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51ccf8d8-83d2-4dcc-aa84-1a77ba040d50");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Proizvod");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16a3dff7-8d1b-4f7f-9634-7eec7228a874", "8deaf628-fccc-4ac3-b6f4-e6093a7aad71", "Admin", "ADMIN" },
                    { "96cf9f2b-2d77-411c-b4bc-efa64b03985b", "3e71fc2a-9912-498f-83c4-3ced47d19122", "Korisnik", "KORISNIK" },
                    { "9ae77795-bc74-462c-9a21-97a9cde2df7e", "a57b2ca0-7e9a-4bf2-a287-823ce99e532a", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c0b57ba-7490-4a4c-b110-56c4344566ed", 0, "Mahala", "123", "5675e805-f997-4900-b977-4baf6995453a", new DateTime(2022, 11, 24, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(9515), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "d7e38fda-6430-4c3d-bbf8-c8ccc6e54c29", 2, false, null });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class dodajSliku : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05e69cda-ad2d-4e21-a483-0349a8f26c25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62f6d665-ee3f-457c-960a-b03fa29533ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "639ec1fb-b368-4360-af3f-6bf174fbf174");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "822909e4-1358-4536-b399-21363de09d0b");

            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "Slika",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "516902a4-8a1b-481f-b403-491c1de77e51", "966136f7-7046-4bd0-b25c-b178b0e47281", "Zaposlenik", "ZAPOSLENIK" },
                    { "8607c622-4166-4be4-b8d3-db6bc906a807", "0cb6731b-b2f6-489d-9abe-58cf3195e4be", "Admin", "ADMIN" },
                    { "fb88fc5d-0e2d-4554-afef-4c7b10cb55a1", "6f8bf088-bd37-412f-bf6b-acffdace5a30", "Korisnik", "KORISNIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "77ea181a-d192-404d-ab91-fae9c299e5f9", 0, "Mahala", "123", "ec39f5a4-fa74-488d-9442-89d8e79ad0e5", new DateTime(2023, 1, 16, 23, 35, 22, 787, DateTimeKind.Local).AddTicks(6914), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "0ad75d29-29ad-4646-b0ee-d88291bfa9ed", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "516902a4-8a1b-481f-b403-491c1de77e51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8607c622-4166-4be4-b8d3-db6bc906a807");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb88fc5d-0e2d-4554-afef-4c7b10cb55a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77ea181a-d192-404d-ab91-fae9c299e5f9");

            migrationBuilder.DropColumn(
                name: "Opis",
                table: "Slika");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05e69cda-ad2d-4e21-a483-0349a8f26c25", "ad303d1d-1c45-41c3-8acb-82426e505225", "Zaposlenik", "ZAPOSLENIK" },
                    { "62f6d665-ee3f-457c-960a-b03fa29533ab", "cd4995a9-8189-4816-bb2d-a9ed7fdb7719", "Korisnik", "KORISNIK" },
                    { "639ec1fb-b368-4360-af3f-6bf174fbf174", "a49dd0ec-cfa6-491b-8322-31b264e65dfc", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "822909e4-1358-4536-b399-21363de09d0b", 0, "Mahala", "123", "a0f0717c-64b8-4a9c-a398-57dec56502d2", new DateTime(2023, 1, 13, 15, 40, 51, 413, DateTimeKind.Local).AddTicks(2171), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "071160e0-412b-4886-9b18-42041f845cf5", 2, false, null });
        }
    }
}

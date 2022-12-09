using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class ProdavnicaSlika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d5f1e6f-f8f2-4d74-884e-ce33d76670ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8b11fc6-36e9-4476-8ed7-f2134315dd84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eba8f533-2b53-4f79-9ff8-f06ea2516524");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0f17de8-c621-4ea9-a49d-145dd2513fd2");

            migrationBuilder.AddColumn<string>(
                name: "Slika",
                table: "Prodavnica",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b64472e-655a-4e3c-a151-74966266b079", "fcb12a9f-4a89-42f7-8a5e-06a7afbede2c", "Admin", "ADMIN" },
                    { "67508616-e330-4f2e-abd6-dd202afc0c0b", "456611b5-69e2-4e81-b67a-9025414a1890", "Zaposlenik", "ZAPOSLENIK" },
                    { "cacd732a-e5c4-43d0-8fad-19a7c320c47d", "67000544-3f85-4bcf-8a56-1fb34c881258", "Korisnik", "KORISNIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e60c1c6d-9290-4d5e-91c5-c06a0caf9dc1", 0, "Mahala", "123", "2a7de6ae-2c23-417c-82b4-bb6c75ddfdab", new DateTime(2022, 12, 7, 18, 21, 21, 456, DateTimeKind.Local).AddTicks(1944), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "82b9942a-6dd9-426f-89e7-f9894a842009", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b64472e-655a-4e3c-a151-74966266b079");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67508616-e330-4f2e-abd6-dd202afc0c0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cacd732a-e5c4-43d0-8fad-19a7c320c47d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e60c1c6d-9290-4d5e-91c5-c06a0caf9dc1");

            migrationBuilder.DropColumn(
                name: "Slika",
                table: "Prodavnica");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d5f1e6f-f8f2-4d74-884e-ce33d76670ed", "1efefbfb-353a-46a8-93a8-90b58c01cb6c", "Zaposlenik", "ZAPOSLENIK" },
                    { "a8b11fc6-36e9-4476-8ed7-f2134315dd84", "32da4278-8aab-4dbf-aee8-121efc2db1a0", "Korisnik", "KORISNIK" },
                    { "eba8f533-2b53-4f79-9ff8-f06ea2516524", "3e03209d-c05e-4a7e-b2f0-385c5ff904d7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d0f17de8-c621-4ea9-a49d-145dd2513fd2", 0, "Mahala", "123", "39c668ce-d882-4f38-8c04-da0dd213a5bf", new DateTime(2022, 12, 7, 13, 19, 57, 707, DateTimeKind.Local).AddTicks(5095), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "f841f7e3-9192-44f5-b5dd-42f7cad1c71e", 2, false, null });
        }
    }
}

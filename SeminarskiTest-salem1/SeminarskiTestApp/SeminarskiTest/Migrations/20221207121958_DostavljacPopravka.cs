using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class DostavljacPopravka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04dead37-4097-4cf8-b10f-46862e77eeff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fba0b9f-a1f6-4617-8b6a-00091227e4ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b865bfa4-782b-498b-9d42-0c2dead7cebd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db5dfc5a-65a9-4959-9dc8-92f3448409d8");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04dead37-4097-4cf8-b10f-46862e77eeff", "f56826c0-767f-47fd-b7f2-ce3ad2e87216", "Korisnik", "KORISNIK" },
                    { "4fba0b9f-a1f6-4617-8b6a-00091227e4ac", "5baa88df-fd01-4002-901e-aabb56693a79", "Zaposlenik", "ZAPOSLENIK" },
                    { "b865bfa4-782b-498b-9d42-0c2dead7cebd", "645d004b-5ef1-41e4-adec-af0e34aad83f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "db5dfc5a-65a9-4959-9dc8-92f3448409d8", 0, "Mahala", "123", "ffc70adc-99fb-4910-8f9b-00c883ddd02d", new DateTime(2022, 12, 7, 13, 19, 13, 543, DateTimeKind.Local).AddTicks(9760), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "e02ec52d-346d-4754-ad6f-ee7971afdca7", 2, false, null });
        }
    }
}

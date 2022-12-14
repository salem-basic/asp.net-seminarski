using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class ProizvodKorisnik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_AspNetUsers_KorisnikId",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_KorisnikId",
                table: "Proizvod");

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
                name: "KorisnikId",
                table: "Proizvod");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "316c8e55-2cb3-4f24-8c9f-065f752cd0cb", "543493e7-07ec-415d-9f5d-38597a227f9d", "Korisnik", "KORISNIK" },
                    { "474d54db-4154-4805-8705-68b8397b950b", "5cccea71-484e-4712-8a80-2a0b1ae93b8e", "Admin", "ADMIN" },
                    { "e14aeee3-865c-44df-bc3e-61a6095e31d5", "44363a85-4d6a-4968-988f-6de0150ad857", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3e4777a5-8e93-4edf-844a-0ef05c4a972c", 0, "Mahala", "123", "8b2494c0-0402-40aa-a4a3-efec405f3bb0", new DateTime(2022, 12, 12, 12, 4, 22, 923, DateTimeKind.Local).AddTicks(7514), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "caa0387c-a617-44bc-97b5-170a79052739", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "316c8e55-2cb3-4f24-8c9f-065f752cd0cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "474d54db-4154-4805-8705-68b8397b950b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e14aeee3-865c-44df-bc3e-61a6095e31d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e4777a5-8e93-4edf-844a-0ef05c4a972c");

            migrationBuilder.AddColumn<string>(
                name: "KorisnikId",
                table: "Proizvod",
                type: "nvarchar(450)",
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

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_KorisnikId",
                table: "Proizvod",
                column: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_AspNetUsers_KorisnikId",
                table: "Proizvod",
                column: "KorisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class ProizvodDobavljac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Dobavljac_DobavljacId",
                table: "Proizvod");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13e021e2-7f75-4ae6-9f55-72392c0af91a", "69abf588-fc0f-440d-9303-12f768db1ed4", "Korisnik", "KORISNIK" },
                    { "17b453df-ba61-4a04-9244-3763a79d0637", "5d74ac87-be0f-466f-9910-e32f672bd831", "Zaposlenik", "ZAPOSLENIK" },
                    { "4a9ecc64-1b77-49d2-bf95-3bf3890493b8", "c06732d8-0220-4a3e-9bd5-d2a3bdf45664", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a1eb5d7b-502b-4307-82ff-c0f46d2326b1", 0, "Mahala", "123", "66ecb55b-6070-4ca9-a869-50e34cf5fffc", new DateTime(2022, 12, 3, 16, 58, 19, 890, DateTimeKind.Local).AddTicks(2720), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "ecbe415e-7e0b-44fd-afe4-b9b1efbe4546", 2, false, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Dobavljac_DobavljacId",
                table: "Proizvod",
                column: "DobavljacId",
                principalTable: "Dobavljac",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Dobavljac_DobavljacId",
                table: "Proizvod");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13e021e2-7f75-4ae6-9f55-72392c0af91a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17b453df-ba61-4a04-9244-3763a79d0637");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a9ecc64-1b77-49d2-bf95-3bf3890493b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1eb5d7b-502b-4307-82ff-c0f46d2326b1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Dobavljac_DobavljacId",
                table: "Proizvod",
                column: "DobavljacId",
                principalTable: "Dobavljac",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

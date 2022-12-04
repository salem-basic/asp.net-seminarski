using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class KorisnikIdmalo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_AspNetUsers_KorisnikID",
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

            migrationBuilder.RenameColumn(
                name: "KorisnikID",
                table: "Proizvod",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvod_KorisnikID",
                table: "Proizvod",
                newName: "IX_Proizvod_KorisnikId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2995c947-38a0-4422-94d1-f42c60ef9bad", "122a91af-1b1d-4876-ae8c-8e3090153815", "Admin", "ADMIN" },
                    { "953c03fd-b431-455c-be37-bf8ee613c897", "a5c26c42-8f44-4596-bf73-819faecacdec", "Korisnik", "KORISNIK" },
                    { "e444600f-966b-46b5-9e37-4daf15a0ecd0", "5701464a-a490-40f3-89d8-42d74baa5471", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ea267436-68b7-43a4-87e0-7963608315f7", 0, "Mahala", "123", "7e32c297-cd08-481d-bca4-6b06c934f2ea", new DateTime(2022, 12, 4, 13, 22, 13, 960, DateTimeKind.Local).AddTicks(1087), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "f6bd4c24-5b32-4b3c-9344-a61c50c6499a", 2, false, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_AspNetUsers_KorisnikId",
                table: "Proizvod",
                column: "KorisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_AspNetUsers_KorisnikId",
                table: "Proizvod");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2995c947-38a0-4422-94d1-f42c60ef9bad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "953c03fd-b431-455c-be37-bf8ee613c897");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e444600f-966b-46b5-9e37-4daf15a0ecd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea267436-68b7-43a4-87e0-7963608315f7");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "Proizvod",
                newName: "KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Proizvod_KorisnikId",
                table: "Proizvod",
                newName: "IX_Proizvod_KorisnikID");

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
                name: "FK_Proizvod_AspNetUsers_KorisnikID",
                table: "Proizvod",
                column: "KorisnikID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class recenzija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "314e15e8-5faa-4428-baf8-744ab69498aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a88dd54-d4a0-45a4-ac22-b7ba56b1e72c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a264aead-d4de-4e75-8b40-3b6db5430798");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1735668c-c05c-4344-a7e3-553f4fad8cb8");

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ocjena = table.Column<int>(type: "int", nullable: false),
                    proizvodId = table.Column<int>(type: "int", nullable: false),
                    korisnikId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recenzija_AspNetUsers_korisnikId",
                        column: x => x.korisnikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recenzija_Proizvod_proizvodId",
                        column: x => x.proizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_korisnikId",
                table: "Recenzija",
                column: "korisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_proizvodId",
                table: "Recenzija",
                column: "proizvodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recenzija");

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
                    { "314e15e8-5faa-4428-baf8-744ab69498aa", "07a79d7a-e9b7-4fa0-ba8a-1f5ac23d6ae7", "Zaposlenik", "ZAPOSLENIK" },
                    { "7a88dd54-d4a0-45a4-ac22-b7ba56b1e72c", "bdbed887-b4cd-4ae0-80cc-a6b9a8324b81", "Korisnik", "KORISNIK" },
                    { "a264aead-d4de-4e75-8b40-3b6db5430798", "9548c8fe-ca17-4b38-999b-7f1f22381cf2", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1735668c-c05c-4344-a7e3-553f4fad8cb8", 0, "Mahala", "123", "c5a9cf6f-6f45-4f85-b665-e9fb08f8810d", new DateTime(2022, 12, 14, 19, 10, 39, 663, DateTimeKind.Local).AddTicks(2156), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "0989d409-4baf-4137-9308-f933fe129386", 2, false, null });
        }
    }
}

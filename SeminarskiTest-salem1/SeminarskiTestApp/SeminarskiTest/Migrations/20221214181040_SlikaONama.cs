using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class SlikaONama : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slika_Proizvod_ProizvodId",
                table: "Slika");

            migrationBuilder.DropIndex(
                name: "IX_Slika_ProizvodId",
                table: "Slika");

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

            migrationBuilder.DropColumn(
                name: "ProizvodId",
                table: "Slika");

            migrationBuilder.RenameColumn(
                name: "SlikaProizvoda",
                table: "Slika",
                newName: "SlikaSlika");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "SlikaSlika",
                table: "Slika",
                newName: "SlikaProizvoda");

            migrationBuilder.AddColumn<int>(
                name: "ProizvodId",
                table: "Slika",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Slika_ProizvodId",
                table: "Slika",
                column: "ProizvodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Slika_Proizvod_ProizvodId",
                table: "Slika",
                column: "ProizvodId",
                principalTable: "Proizvod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class godinaBezKorisnika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_AspNetUsers_korisnikId",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_korisnikId",
                table: "Recenzija");

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

            migrationBuilder.DropColumn(
                name: "korisnikId",
                table: "Recenzija");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "54c427c4-3c25-4225-8cea-137587019865", "26729126-027f-482f-a679-b38454bd1451", "Admin", "ADMIN" },
                    { "e9994005-b08e-46f7-9adc-a68e38a166cb", "7ddb5079-62a8-4ad5-956e-14132d575b16", "Zaposlenik", "ZAPOSLENIK" },
                    { "f0e0869a-a8f3-437d-926b-ffcc41bd23fd", "1812bd82-abe1-42e3-b212-001ea6a9cecb", "Korisnik", "KORISNIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a178325a-5c51-4ee5-89dc-d5038f63ffcd", 0, "Mahala", "123", "203e27dd-e5ba-459b-89ea-8df56550ac67", new DateTime(2023, 1, 8, 22, 22, 2, 923, DateTimeKind.Local).AddTicks(2304), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "9d3d3262-44a0-44d0-b7e4-6f523e094576", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54c427c4-3c25-4225-8cea-137587019865");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9994005-b08e-46f7-9adc-a68e38a166cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0e0869a-a8f3-437d-926b-ffcc41bd23fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a178325a-5c51-4ee5-89dc-d5038f63ffcd");

            migrationBuilder.AddColumn<string>(
                name: "korisnikId",
                table: "Recenzija",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_korisnikId",
                table: "Recenzija",
                column: "korisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_AspNetUsers_korisnikId",
                table: "Recenzija",
                column: "korisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

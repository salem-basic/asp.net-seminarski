using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class Prodavnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "282f2711-0585-4eba-aaea-8badb8efbced", "33f6eb15-2e2a-4c45-b9bc-2f74ef6ad06b", "Zaposlenik", "ZAPOSLENIK" },
                    { "60e0abd8-9da2-4b92-8a7c-43d1214cd5d1", "13cac03b-91f7-47f2-95f9-6fd3a12d261e", "Admin", "ADMIN" },
                    { "7f61d86e-2265-436e-b35e-bd23892a9c80", "fd92672a-fdcb-462f-b98d-f245bfde2d67", "Korisnik", "KORISNIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5195dc40-d26f-4dc5-9fcf-7a5f2d592f20", 0, "Mahala", "123", "ad82001e-e360-4cc1-beee-c600691315d3", new DateTime(2022, 12, 5, 20, 31, 53, 36, DateTimeKind.Local).AddTicks(5876), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "10e5c903-1ffd-42a2-b7a4-789fb341c85f", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "282f2711-0585-4eba-aaea-8badb8efbced");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60e0abd8-9da2-4b92-8a7c-43d1214cd5d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f61d86e-2265-436e-b35e-bd23892a9c80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5195dc40-d26f-4dc5-9fcf-7a5f2d592f20");

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
        }
    }
}

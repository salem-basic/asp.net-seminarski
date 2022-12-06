using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class ProdavnicaPopravka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Prodavnica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodavnica", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d91310c-0138-4a8c-a7db-dff0deb45aca", "42078159-bd52-4925-b254-4bb6a70daaac", "Zaposlenik", "ZAPOSLENIK" },
                    { "7aa5f6d8-77c3-444e-9716-c611722b4ca5", "5bc6a5d8-f9dd-4711-b608-58074be3bbe1", "Korisnik", "KORISNIK" },
                    { "a111bc33-4f67-4100-871b-aa4c1220c5bd", "c641b98f-fcaf-4b33-a88a-188fe06175eb", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "21603a6a-854c-4515-8cf6-27aedd182f0e", 0, "Mahala", "123", "5c182022-1586-4aed-92e2-471726678545", new DateTime(2022, 12, 5, 21, 18, 16, 914, DateTimeKind.Local).AddTicks(369), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "1f95573d-ab81-43db-9d5b-6952089c56e5", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prodavnica");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d91310c-0138-4a8c-a7db-dff0deb45aca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7aa5f6d8-77c3-444e-9716-c611722b4ca5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a111bc33-4f67-4100-871b-aa4c1220c5bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21603a6a-854c-4515-8cf6-27aedd182f0e");

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
    }
}

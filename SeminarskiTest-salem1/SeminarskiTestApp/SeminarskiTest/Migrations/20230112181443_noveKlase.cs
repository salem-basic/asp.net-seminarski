using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class noveKlase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "117934af-18a8-4f58-80a8-3edb42fd46e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a72a5346-a6ec-47fe-bcd5-8708000508f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f075c0f0-ddc9-4e2a-8905-360a9a7ff853");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac20dcc8-e6fc-401b-b574-1cabb04c4df4");

            migrationBuilder.DropColumn(
                name: "Smjena",
                table: "EvidencijaZaposlenika");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumAktivnosti",
                table: "EvidencijaZaposlenika",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "KorisnikId",
                table: "EvidencijaZaposlenika",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a4ea892-eb12-423a-8454-42c162942b50", "0f835d67-df0e-43dd-a526-1162f72bb577", "Korisnik", "KORISNIK" },
                    { "4957a825-0b61-4b2b-bf4d-dabfc5009bea", "23186de1-b109-42a2-93ce-9c661cea61f9", "Admin", "ADMIN" },
                    { "d8491393-2f0c-450f-b365-007760917c8d", "a41680d4-3672-4fee-a816-2a8d846993b0", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3b4f6afd-41ec-4b55-88e7-41e22d4a6aa2", 0, "Mahala", "123", "75e21ab9-e62e-4e12-93a0-13a480359627", new DateTime(2023, 1, 12, 19, 14, 42, 553, DateTimeKind.Local).AddTicks(9810), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "f45d31a0-d59a-4370-a843-acaed1f8f679", 2, false, null });

            migrationBuilder.CreateIndex(
                name: "IX_EvidencijaZaposlenika_KorisnikId",
                table: "EvidencijaZaposlenika",
                column: "KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvidencijaZaposlenika_AspNetUsers_KorisnikId",
                table: "EvidencijaZaposlenika",
                column: "KorisnikId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EvidencijaZaposlenika_AspNetUsers_KorisnikId",
                table: "EvidencijaZaposlenika");

            migrationBuilder.DropIndex(
                name: "IX_EvidencijaZaposlenika_KorisnikId",
                table: "EvidencijaZaposlenika");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a4ea892-eb12-423a-8454-42c162942b50");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4957a825-0b61-4b2b-bf4d-dabfc5009bea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8491393-2f0c-450f-b365-007760917c8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b4f6afd-41ec-4b55-88e7-41e22d4a6aa2");

            migrationBuilder.DropColumn(
                name: "DatumAktivnosti",
                table: "EvidencijaZaposlenika");

            migrationBuilder.DropColumn(
                name: "KorisnikId",
                table: "EvidencijaZaposlenika");

            migrationBuilder.AddColumn<string>(
                name: "Smjena",
                table: "EvidencijaZaposlenika",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "117934af-18a8-4f58-80a8-3edb42fd46e0", "1e41e22a-b23f-471e-8985-08c4380f4f72", "Zaposlenik", "ZAPOSLENIK" },
                    { "a72a5346-a6ec-47fe-bcd5-8708000508f5", "636fcfb7-0409-4760-81ba-86723c156577", "Admin", "ADMIN" },
                    { "f075c0f0-ddc9-4e2a-8905-360a9a7ff853", "9b034581-6efa-4152-bd94-8dd57e588489", "Korisnik", "KORISNIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ac20dcc8-e6fc-401b-b574-1cabb04c4df4", 0, "Mahala", "123", "5da189b2-3a44-4397-8d06-4a0836645989", new DateTime(2023, 1, 11, 23, 18, 39, 631, DateTimeKind.Local).AddTicks(134), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "f623bb80-1b3f-4bc8-9162-9b63482e5c74", 2, false, null });
        }
    }
}

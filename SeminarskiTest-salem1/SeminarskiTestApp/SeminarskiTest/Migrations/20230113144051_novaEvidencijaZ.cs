using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class novaEvidencijaZ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumOdjave",
                table: "EvidencijaZaposlenika",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumPrijave",
                table: "EvidencijaZaposlenika",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KorisnikIme",
                table: "EvidencijaZaposlenika",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05e69cda-ad2d-4e21-a483-0349a8f26c25", "ad303d1d-1c45-41c3-8acb-82426e505225", "Zaposlenik", "ZAPOSLENIK" },
                    { "62f6d665-ee3f-457c-960a-b03fa29533ab", "cd4995a9-8189-4816-bb2d-a9ed7fdb7719", "Korisnik", "KORISNIK" },
                    { "639ec1fb-b368-4360-af3f-6bf174fbf174", "a49dd0ec-cfa6-491b-8322-31b264e65dfc", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "822909e4-1358-4536-b399-21363de09d0b", 0, "Mahala", "123", "a0f0717c-64b8-4a9c-a398-57dec56502d2", new DateTime(2023, 1, 13, 15, 40, 51, 413, DateTimeKind.Local).AddTicks(2171), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "071160e0-412b-4886-9b18-42041f845cf5", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05e69cda-ad2d-4e21-a483-0349a8f26c25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62f6d665-ee3f-457c-960a-b03fa29533ab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "639ec1fb-b368-4360-af3f-6bf174fbf174");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "822909e4-1358-4536-b399-21363de09d0b");

            migrationBuilder.DropColumn(
                name: "DatumOdjave",
                table: "EvidencijaZaposlenika");

            migrationBuilder.DropColumn(
                name: "DatumPrijave",
                table: "EvidencijaZaposlenika");

            migrationBuilder.DropColumn(
                name: "KorisnikIme",
                table: "EvidencijaZaposlenika");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumAktivnosti",
                table: "EvidencijaZaposlenika",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}

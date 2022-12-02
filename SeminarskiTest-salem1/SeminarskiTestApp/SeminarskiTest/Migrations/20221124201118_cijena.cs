using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class cijena : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1cafc0f7-687b-488b-a095-b11e6d85c305");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e83a1-e8ca-46fe-9814-23c1f46dde89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5e999a1-8bef-42e6-b174-b4a4f1d98c28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5564392-4bd9-4b2d-a7be-5fc74715096b");

            migrationBuilder.AddColumn<double>(
                name: "Cijena",
                table: "Proizvod",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16a3dff7-8d1b-4f7f-9634-7eec7228a874", "8deaf628-fccc-4ac3-b6f4-e6093a7aad71", "Admin", "ADMIN" },
                    { "96cf9f2b-2d77-411c-b4bc-efa64b03985b", "3e71fc2a-9912-498f-83c4-3ced47d19122", "Korisnik", "KORISNIK" },
                    { "9ae77795-bc74-462c-9a21-97a9cde2df7e", "a57b2ca0-7e9a-4bf2-a287-823ce99e532a", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7c0b57ba-7490-4a4c-b110-56c4344566ed", 0, "Mahala", "123", "5675e805-f997-4900-b977-4baf6995453a", new DateTime(2022, 11, 24, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(9515), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "d7e38fda-6430-4c3d-bbf8-c8ccc6e54c29", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16a3dff7-8d1b-4f7f-9634-7eec7228a874");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96cf9f2b-2d77-411c-b4bc-efa64b03985b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ae77795-bc74-462c-9a21-97a9cde2df7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c0b57ba-7490-4a4c-b110-56c4344566ed");

            migrationBuilder.DropColumn(
                name: "Cijena",
                table: "Proizvod");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1cafc0f7-687b-488b-a095-b11e6d85c305", "3049c3aa-590a-4f0e-abda-d095d3a9302b", "Admin", "ADMIN" },
                    { "423e83a1-e8ca-46fe-9814-23c1f46dde89", "17e03696-55c8-4225-ba2f-8c71a65fc557", "Korisnik", "KORISNIK" },
                    { "d5e999a1-8bef-42e6-b174-b4a4f1d98c28", "bceec25b-6e6c-4ccc-bbb6-47229b5fc053", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c5564392-4bd9-4b2d-a7be-5fc74715096b", 0, "Mahala", "123", "b1d39260-f973-4110-b7ef-85fbc268f011", new DateTime(2022, 11, 22, 11, 29, 31, 552, DateTimeKind.Local).AddTicks(6049), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "2bb68c50-ad85-45ff-8050-8667b6269cc6", 2, false, null });
        }
    }
}

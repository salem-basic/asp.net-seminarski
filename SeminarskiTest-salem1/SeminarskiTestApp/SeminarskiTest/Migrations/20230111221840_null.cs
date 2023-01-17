using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class @null : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "447f5f39-2524-426c-afbf-ce109ad96270");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8266d0aa-01d2-4c33-b035-3d31a0b79537");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90fb0350-841f-48aa-a066-c912ce6c74b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eda09728-e88f-47d1-b992-ed3dc1123c31");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "117934af-18a8-4f58-80a8-3edb42fd46e0", "1e41e22a-b23f-471e-8985-08c4380f4f72", "Zaposlenik", "ZAPOSLENIK" },
            //        { "a72a5346-a6ec-47fe-bcd5-8708000508f5", "636fcfb7-0409-4760-81ba-86723c156577", "Admin", "ADMIN" },
            //        { "f075c0f0-ddc9-4e2a-8905-360a9a7ff853", "9b034581-6efa-4152-bd94-8dd57e588489", "Korisnik", "KORISNIK" }
            //    });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ac20dcc8-e6fc-401b-b574-1cabb04c4df4", 0, "Mahala", "123", "5da189b2-3a44-4397-8d06-4a0836645989", new DateTime(2023, 1, 11, 23, 18, 39, 631, DateTimeKind.Local).AddTicks(134), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "f623bb80-1b3f-4bc8-9162-9b63482e5c74", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "447f5f39-2524-426c-afbf-ce109ad96270", "dba05305-a4b0-4601-b2b2-cf6b7dc35a4a", "Zaposlenik", "ZAPOSLENIK" },
                    { "8266d0aa-01d2-4c33-b035-3d31a0b79537", "f0ed276f-d113-49b6-b06f-7c723b7c90ce", "Korisnik", "KORISNIK" },
                    { "90fb0350-841f-48aa-a066-c912ce6c74b7", "7077ad31-93da-42f9-b1b3-162830f26817", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eda09728-e88f-47d1-b992-ed3dc1123c31", 0, "Mahala", "123", "a06d4f34-9c29-4b5a-a095-bb164457b561", new DateTime(2023, 1, 11, 22, 52, 54, 872, DateTimeKind.Local).AddTicks(3735), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "5799df07-434e-4e3a-8663-6978ba108380", 2, false, null });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class recenzijanull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3965d02a-4f83-4625-bc7f-e2573e3a2f95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8bcc452-c19b-469d-9e7e-325da5c5b381");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ead25221-304d-4dc2-8c09-47bfd72e0328");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5359c478-1b8e-4fe9-b5a3-3bb23a733f04");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "728e2f2f-741b-4f15-8de4-4b34414af6a0", "4099f9f1-08bc-4232-a12a-077568d71fab", "Korisnik", "KORISNIK" },
            //        { "74503884-4faa-45c1-b002-ab27311106f0", "9ad07d8a-46a1-496b-b6fd-552123c9a980", "Admin", "ADMIN" },
            //        { "b19861ed-8c6a-446c-ade0-e45b93f5e302", "c700b3ec-ad0c-4f64-8602-9e59ae18003c", "Zaposlenik", "ZAPOSLENIK" }
            //    });

            //migrationBuilder.InsertData(
            //    table: "AspNetUsers",
            //    columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
            //    values: new object[] { "73f2202b-99a5-4643-b85c-73051db4256a", 0, "Mahala", "123", "46b12c1c-d47b-4ee6-b156-bc6d1da0ccd3", new DateTime(2023, 1, 9, 21, 55, 35, 473, DateTimeKind.Local).AddTicks(7725), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "ccb190a3-e803-4d5f-b7ec-b75defc31c8c", 2, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "728e2f2f-741b-4f15-8de4-4b34414af6a0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74503884-4faa-45c1-b002-ab27311106f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b19861ed-8c6a-446c-ade0-e45b93f5e302");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73f2202b-99a5-4643-b85c-73051db4256a");

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proizvodId = table.Column<int>(type: "int", nullable: false),
                    ocjena = table.Column<int>(type: "int", nullable: false),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.id);
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
                    { "3965d02a-4f83-4625-bc7f-e2573e3a2f95", "98c64ff3-def1-4f40-b53b-2b5c9bff28ec", "Zaposlenik", "ZAPOSLENIK" },
                    { "c8bcc452-c19b-469d-9e7e-325da5c5b381", "472043e3-5d44-4952-8ed4-83992d99bc48", "Admin", "ADMIN" },
                    { "ead25221-304d-4dc2-8c09-47bfd72e0328", "b30392dd-7074-4265-a386-16c1d53d6394", "Korisnik", "KORISNIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5359c478-1b8e-4fe9-b5a3-3bb23a733f04", 0, "Mahala", "123", "e39ac706-730d-48e0-97e3-2a7d3646fe8f", new DateTime(2023, 1, 9, 21, 53, 15, 613, DateTimeKind.Local).AddTicks(2151), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "0ea39cbd-60aa-4a33-8f94-87203ec0d9be", 2, false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_proizvodId",
                table: "Recenzija",
                column: "proizvodId");
        }
    }
}

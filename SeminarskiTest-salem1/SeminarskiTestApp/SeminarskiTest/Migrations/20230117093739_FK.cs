using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d048bbb1-2f34-4fbf-b230-690394e0a33e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1033f31-7c92-4881-a015-94490c7759de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe94c4db-2ae5-47c7-ad97-b9cb90c69631");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "140cfc5f-7716-45fe-9d7a-bd4ffc0540b6");

            migrationBuilder.AddColumn<int>(
                name: "prodavnicaId",
                table: "Slika",
                type: "int",
                nullable: false,
                defaultValue: 0);

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "c4aed8e2-d3e8-44a7-ae20-34b363e6146e", "4cd8536c-1cf8-4ddd-b793-f98dc0113eb7", "Admin", "ADMIN" },
            //        { "c95eaded-e5bb-4e99-b14f-a3e1ead2f80e", "a785a5d2-25f2-4453-91a0-39bdabeffe13", "Korisnik", "KORISNIK" },
            //        { "e82cb2e5-c8c7-4716-b58c-949a94d14612", "6411edbc-d9ca-44ef-b1a9-fdff7d7bff4c", "Zaposlenik", "ZAPOSLENIK" }
            //    });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6be158be-7878-4c08-a244-40ebf79e8da7", 0, "Mahala", "123", "c806c3c1-947d-4341-841d-e18dfed88fae", new DateTime(2023, 1, 17, 10, 37, 38, 855, DateTimeKind.Local).AddTicks(9028), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "1013ea7c-d93b-4ee3-bfcf-bd786cf36200", 2, false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Slika_prodavnicaId",
                table: "Slika",
                column: "prodavnicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Slika_Prodavnica_prodavnicaId",
                table: "Slika",
                column: "prodavnicaId",
                principalTable: "Prodavnica",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Slika_Prodavnica_prodavnicaId",
                table: "Slika");

            migrationBuilder.DropIndex(
                name: "IX_Slika_prodavnicaId",
                table: "Slika");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4aed8e2-d3e8-44a7-ae20-34b363e6146e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c95eaded-e5bb-4e99-b14f-a3e1ead2f80e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e82cb2e5-c8c7-4716-b58c-949a94d14612");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6be158be-7878-4c08-a244-40ebf79e8da7");

            migrationBuilder.DropColumn(
                name: "prodavnicaId",
                table: "Slika");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d048bbb1-2f34-4fbf-b230-690394e0a33e", "b8dc9256-fb85-4d6c-913e-3eebc59f2fd9", "Korisnik", "KORISNIK" },
                    { "d1033f31-7c92-4881-a015-94490c7759de", "0ff39915-ecb2-4913-a0ef-1f6eab473082", "Zaposlenik", "ZAPOSLENIK" },
                    { "fe94c4db-2ae5-47c7-ad97-b9cb90c69631", "1de69a5a-cb2c-4f4e-ab56-487bfb12f242", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "140cfc5f-7716-45fe-9d7a-bd4ffc0540b6", 0, "Mahala", "123", "af970d0f-ded3-4995-8703-9f5b1bb685ef", new DateTime(2023, 1, 17, 10, 35, 34, 192, DateTimeKind.Local).AddTicks(4671), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "43744d2d-21e7-49e0-b968-9b6e69a48f81", 2, false, null });
        }
    }
}

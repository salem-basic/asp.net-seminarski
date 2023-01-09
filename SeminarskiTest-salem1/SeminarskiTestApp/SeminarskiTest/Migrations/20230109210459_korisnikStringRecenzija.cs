using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class korisnikStringRecenzija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recenzija_AspNetUsers_korisnikId1",
                table: "Recenzija");

            migrationBuilder.DropIndex(
                name: "IX_Recenzija_korisnikId1",
                table: "Recenzija");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "652df689-99a3-43bc-849a-78bb02289cc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8093687d-057b-4851-bd64-94bf2c6e644e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e577b7a4-b889-43b5-beb2-53ba966a7a06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2713683d-fd77-4984-b2a3-bc038149123e");

            migrationBuilder.DropColumn(
                name: "korisnikId1",
                table: "Recenzija");

            migrationBuilder.AlterColumn<string>(
                name: "korisnikId",
                table: "Recenzija",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
            //    values: new object[,]
            //    {
            //        { "3447fbaf-7e95-468e-8a40-70cb9a9f6a74", "8f3ce2eb-7444-48c0-82f7-09bd86eb3e5f", "Admin", "ADMIN" },
            //        { "53e4d7eb-33d4-40ec-a2ed-b42ef4b18668", "8edbf1b6-f59b-46ac-b802-e942023b3342", "Korisnik", "KORISNIK" },
            //        { "e8d22a04-7464-480d-93ad-690b06e22cf9", "aef92fd9-390c-471e-9665-a0e3a52a0bc5", "Zaposlenik", "ZAPOSLENIK" }
            //    });

            //migrationBuilder.InsertData(
            //    table: "AspNetUsers",
            //    columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
            //    values: new object[] { "17a4f2fd-41c9-48e4-bc75-4663b38525fe", 0, "Mahala", "123", "c4b593df-84ff-462a-9f9b-07687c5f7cf3", new DateTime(2023, 1, 9, 22, 4, 59, 73, DateTimeKind.Local).AddTicks(7447), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "7b96e610-2daf-4b6a-a8ae-e9a75e6883ff", 2, false, null });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: "3447fbaf-7e95-468e-8a40-70cb9a9f6a74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53e4d7eb-33d4-40ec-a2ed-b42ef4b18668");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8d22a04-7464-480d-93ad-690b06e22cf9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17a4f2fd-41c9-48e4-bc75-4663b38525fe");

            migrationBuilder.AlterColumn<int>(
                name: "korisnikId",
                table: "Recenzija",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "korisnikId1",
                table: "Recenzija",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "652df689-99a3-43bc-849a-78bb02289cc0", "b7a8f365-09e0-4604-bb58-d58c89749176", "Zaposlenik", "ZAPOSLENIK" },
                    { "8093687d-057b-4851-bd64-94bf2c6e644e", "2b5abc8b-5f7a-4851-8474-77e768c8375d", "Korisnik", "KORISNIK" },
                    { "e577b7a4-b889-43b5-beb2-53ba966a7a06", "aff809a7-8d6f-42d0-92ff-86ce745fd321", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2713683d-fd77-4984-b2a3-bc038149123e", 0, "Mahala", "123", "39bb8a7d-6f0a-4a7c-8612-f2c9a78cb489", new DateTime(2023, 1, 9, 22, 2, 16, 992, DateTimeKind.Local).AddTicks(5353), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "a0f38bf7-d454-45de-b26f-26299c0373cb", 2, false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_korisnikId1",
                table: "Recenzija",
                column: "korisnikId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Recenzija_AspNetUsers_korisnikId1",
                table: "Recenzija",
                column: "korisnikId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class Dostavljac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorpaProizvod");

            migrationBuilder.DropTable(
                name: "SpecialOffer");

            migrationBuilder.DropTable(
                name: "Transakcija");

            migrationBuilder.DropTable(
                name: "Korpa");

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

            migrationBuilder.AddColumn<int>(
                name: "DostavljacId",
                table: "Narudzba",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KarticaId",
                table: "Narudzba",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Kolicina",
                table: "Narudzba",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TotalCijena",
                table: "Narudzba",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Dostavljac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrzavaId = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostavljac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dostavljac_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04dead37-4097-4cf8-b10f-46862e77eeff", "f56826c0-767f-47fd-b7f2-ce3ad2e87216", "Korisnik", "KORISNIK" },
                    { "4fba0b9f-a1f6-4617-8b6a-00091227e4ac", "5baa88df-fd01-4002-901e-aabb56693a79", "Zaposlenik", "ZAPOSLENIK" },
                    { "b865bfa4-782b-498b-9d42-0c2dead7cebd", "645d004b-5ef1-41e4-adec-af0e34aad83f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "db5dfc5a-65a9-4959-9dc8-92f3448409d8", 0, "Mahala", "123", "ffc70adc-99fb-4910-8f9b-00c883ddd02d", new DateTime(2022, 12, 7, 13, 19, 13, 543, DateTimeKind.Local).AddTicks(9760), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "e02ec52d-346d-4754-ad6f-ee7971afdca7", 2, false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_DostavljacId",
                table: "Narudzba",
                column: "DostavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KarticaId",
                table: "Narudzba",
                column: "KarticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dostavljac_DrzavaId",
                table: "Dostavljac",
                column: "DrzavaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Dostavljac_DostavljacId",
                table: "Narudzba",
                column: "DostavljacId",
                principalTable: "Dostavljac",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Kartica_KarticaId",
                table: "Narudzba",
                column: "KarticaId",
                principalTable: "Kartica",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Dostavljac_DostavljacId",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Kartica_KarticaId",
                table: "Narudzba");

            migrationBuilder.DropTable(
                name: "Dostavljac");

            migrationBuilder.DropIndex(
                name: "IX_Narudzba_DostavljacId",
                table: "Narudzba");

            migrationBuilder.DropIndex(
                name: "IX_Narudzba_KarticaId",
                table: "Narudzba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04dead37-4097-4cf8-b10f-46862e77eeff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fba0b9f-a1f6-4617-8b6a-00091227e4ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b865bfa4-782b-498b-9d42-0c2dead7cebd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db5dfc5a-65a9-4959-9dc8-92f3448409d8");

            migrationBuilder.DropColumn(
                name: "DostavljacId",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "KarticaId",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "TotalCijena",
                table: "Narudzba");

            migrationBuilder.CreateTable(
                name: "Korpa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korpa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialOffer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialOffer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transakcija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KarticaId = table.Column<int>(type: "int", nullable: false),
                    NarudzbaId = table.Column<int>(type: "int", nullable: false),
                    ValutaId = table.Column<int>(type: "int", nullable: false),
                    BrojTransakcije = table.Column<int>(type: "int", nullable: false),
                    DatumTransakcije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VrstaTransakcije = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transakcija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transakcija_Kartica_KarticaId",
                        column: x => x.KarticaId,
                        principalTable: "Kartica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transakcija_Narudzba_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transakcija_Valuta_ValutaId",
                        column: x => x.ValutaId,
                        principalTable: "Valuta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorpaProizvod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    ValutaId = table.Column<int>(type: "int", nullable: true),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    KorpaId = table.Column<int>(type: "int", nullable: true),
                    Popust = table.Column<double>(type: "float", nullable: false),
                    Stanje = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorpaProizvod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KorpaProizvod_Korpa_KorpaId",
                        column: x => x.KorpaId,
                        principalTable: "Korpa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KorpaProizvod_Proizvod_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorpaProizvod_Valuta_ValutaId",
                        column: x => x.ValutaId,
                        principalTable: "Valuta",
                        principalColumn: "Id");
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

            migrationBuilder.CreateIndex(
                name: "IX_KorpaProizvod_KorpaId",
                table: "KorpaProizvod",
                column: "KorpaId");

            migrationBuilder.CreateIndex(
                name: "IX_KorpaProizvod_ProizvodId",
                table: "KorpaProizvod",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_KorpaProizvod_ValutaId",
                table: "KorpaProizvod",
                column: "ValutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_KarticaId",
                table: "Transakcija",
                column: "KarticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_NarudzbaId",
                table: "Transakcija",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_Transakcija_ValutaId",
                table: "Transakcija",
                column: "ValutaId");
        }
    }
}

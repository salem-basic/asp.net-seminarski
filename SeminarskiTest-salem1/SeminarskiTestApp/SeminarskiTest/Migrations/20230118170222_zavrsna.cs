using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarskiTest.Migrations
{
    public partial class zavrsna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivDrzave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skracenica = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kartica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vrsta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kartica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKategorije = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Materijal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kvalitet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prodavnica",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<int>(type: "int", nullable: false),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prodavnica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivSpola = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Valuta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valuta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Brend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivBrenda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrzavaId = table.Column<int>(type: "int", nullable: false),
                    Luxury = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brend_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dobavljac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivDobavljaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojDobavljaca = table.Column<int>(type: "int", nullable: false),
                    DrzavaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dobavljac_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "Slika",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlikaSlika = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prodavnicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slika", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Slika_Prodavnica_prodavnicaId",
                        column: x => x.prodavnicaId,
                        principalTable: "Prodavnica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lozinka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DrzavaId = table.Column<int>(type: "int", nullable: false),
                    SpolId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Drzava_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzava",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Spol_SpolId",
                        column: x => x.SpolId,
                        principalTable: "Spol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivProizvoda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValutaId = table.Column<int>(type: "int", nullable: false),
                    Cijena = table.Column<double>(type: "float", nullable: false),
                    SerijskiBroj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategorijaId = table.Column<int>(type: "int", nullable: false),
                    DobavljacId = table.Column<int>(type: "int", nullable: false),
                    BrendId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proizvod_Brend_BrendId",
                        column: x => x.BrendId,
                        principalTable: "Brend",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvod_Dobavljac_DobavljacId",
                        column: x => x.DobavljacId,
                        principalTable: "Dobavljac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Proizvod_Kategorija_KategorijaId",
                        column: x => x.KategorijaId,
                        principalTable: "Kategorija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvod_Valuta_ValutaId",
                        column: x => x.ValutaId,
                        principalTable: "Valuta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvidencijaZaposlenika",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aktivan = table.Column<bool>(type: "bit", nullable: false),
                    DatumPrijave = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumOdjave = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KorisnikId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KorisnikIme = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvidencijaZaposlenika", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvidencijaZaposlenika_AspNetUsers_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojNarudzbe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KorisnikID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DatumNarudzbe = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaID);
                    table.ForeignKey(
                        name: "FK_Narudzba_AspNetUsers_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recenzija",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ocjena = table.Column<int>(type: "int", nullable: false),
                    proizvodId = table.Column<int>(type: "int", nullable: false),
                    korisnikId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    korisnikIme = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzija", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recenzija_AspNetUsers_korisnikId",
                        column: x => x.korisnikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recenzija_Proizvod_proizvodId",
                        column: x => x.proizvodId,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaStavka",
                columns: table => new
                {
                    NarudzbaStavkaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProizvodID = table.Column<int>(type: "int", nullable: false),
                    NarudzbaID = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStavka", x => x.NarudzbaStavkaID);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavka_Narudzba_NarudzbaID",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavka_Proizvod_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0161b16d-520b-430c-90a9-dd084efac7a3", "c77f6d69-8863-49fb-b17d-2eabe0af5562", "Korisnik", "KORISNIK" },
                    { "3f35b8db-27df-4d54-b54a-859982b25551", "3255fa0e-aaee-4a06-ad06-598fdf821fbf", "Admin", "ADMIN" },
                    { "dfe645ff-a0d1-4e7e-b759-8181a2847a27", "82e73b8b-d6aa-4acd-969f-5574abf687ac", "Zaposlenik", "ZAPOSLENIK" }
                });

            migrationBuilder.InsertData(
                table: "Drzava",
                columns: new[] { "Id", "NazivDrzave", "Sifra", "Skracenica" },
                values: new object[] { 2, "Hrvatska", "aslknioasfnewlr", "HR" });

            migrationBuilder.InsertData(
                table: "Spol",
                columns: new[] { "Id", "NazivSpola" },
                values: new object[] { 2, "Zenski" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adresa", "BrojTelefona", "ConcurrencyStamp", "DatumRodjenja", "DrzavaId", "Email", "EmailConfirmed", "Grad", "Ime", "LockoutEnabled", "LockoutEnd", "Lozinka", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prezime", "SecurityStamp", "SpolId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "70688eef-d6fc-4167-bf6c-eebbf5f30ea9", 0, "Mahala", "123", "4e7ad0e7-5e3b-4412-8293-2c1e9ae98690", new DateTime(2023, 1, 18, 18, 2, 22, 375, DateTimeKind.Local).AddTicks(5296), 2, "salem@seminarski.com", false, "Mostar", "Hamza", false, null, "Lozinka1@", null, null, null, null, false, "Taslidza", "278a23d5-fbea-418f-869f-6ecd5098204c", 2, false, null });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DrzavaId",
                table: "AspNetUsers",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SpolId",
                table: "AspNetUsers",
                column: "SpolId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Brend_DrzavaId",
                table: "Brend",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dobavljac_DrzavaId",
                table: "Dobavljac",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dostavljac_DrzavaId",
                table: "Dostavljac",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_EvidencijaZaposlenika_KorisnikId",
                table: "EvidencijaZaposlenika",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KorisnikID",
                table: "Narudzba",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavka_NarudzbaID",
                table: "NarudzbaStavka",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavka_ProizvodID",
                table: "NarudzbaStavka",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_BrendId",
                table: "Proizvod",
                column: "BrendId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_DobavljacId",
                table: "Proizvod",
                column: "DobavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_KategorijaId",
                table: "Proizvod",
                column: "KategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_ValutaId",
                table: "Proizvod",
                column: "ValutaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_korisnikId",
                table: "Recenzija",
                column: "korisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzija_proizvodId",
                table: "Recenzija",
                column: "proizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Slika_prodavnicaId",
                table: "Slika",
                column: "prodavnicaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Dostavljac");

            migrationBuilder.DropTable(
                name: "EvidencijaZaposlenika");

            migrationBuilder.DropTable(
                name: "Kartica");

            migrationBuilder.DropTable(
                name: "NarudzbaStavka");

            migrationBuilder.DropTable(
                name: "Recenzija");

            migrationBuilder.DropTable(
                name: "Slika");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "Prodavnica");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brend");

            migrationBuilder.DropTable(
                name: "Dobavljac");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "Valuta");

            migrationBuilder.DropTable(
                name: "Spol");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}

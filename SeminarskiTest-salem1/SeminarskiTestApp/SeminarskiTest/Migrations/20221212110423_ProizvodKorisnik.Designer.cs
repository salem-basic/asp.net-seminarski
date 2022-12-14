﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeminarskiTest.Data;

#nullable disable

namespace SeminarskiTest.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221212110423_ProizvodKorisnik")]
    partial class ProizvodKorisnik
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "474d54db-4154-4805-8705-68b8397b950b",
                            ConcurrencyStamp = "5cccea71-484e-4712-8a80-2a0b1ae93b8e",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "e14aeee3-865c-44df-bc3e-61a6095e31d5",
                            ConcurrencyStamp = "44363a85-4d6a-4968-988f-6de0150ad857",
                            Name = "Zaposlenik",
                            NormalizedName = "ZAPOSLENIK"
                        },
                        new
                        {
                            Id = "316c8e55-2cb3-4f24-8c9f-065f752cd0cb",
                            ConcurrencyStamp = "543493e7-07ec-415d-9f5d-38597a227f9d",
                            Name = "Korisnik",
                            NormalizedName = "KORISNIK"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SeminarskiTest.Models.Brend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NazivBrenda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brend");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Dobavljac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrojDobavljaca")
                        .HasColumnType("int");

                    b.Property<int?>("DrzavaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("NazivDobavljaca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Dobavljac");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Dostavljac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DrzavaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DrzavaId");

                    b.ToTable("Dostavljac");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Drzava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NazivDrzave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skracenica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drzava");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            NazivDrzave = "Hrvatska",
                            Sifra = "aslknioasfnewlr",
                            Skracenica = "HR"
                        });
                });

            modelBuilder.Entity("SeminarskiTest.Models.EvidencijaZaposlenika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Smjena")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EvidencijaZaposlenika");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Kartica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vrsta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kartica");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NazivKategorije")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Korisnik", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DrzavaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpolId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("DrzavaId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("SpolId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3e4777a5-8e93-4edf-844a-0ef05c4a972c",
                            AccessFailedCount = 0,
                            Adresa = "Mahala",
                            BrojTelefona = "123",
                            ConcurrencyStamp = "8b2494c0-0402-40aa-a4a3-efec405f3bb0",
                            DatumRodjenja = new DateTime(2022, 12, 12, 12, 4, 22, 923, DateTimeKind.Local).AddTicks(7514),
                            DrzavaId = 2,
                            Email = "salem@seminarski.com",
                            EmailConfirmed = false,
                            Grad = "Mostar",
                            Ime = "Hamza",
                            LockoutEnabled = false,
                            Lozinka = "Lozinka1@",
                            PhoneNumberConfirmed = false,
                            Prezime = "Taslidza",
                            SecurityStamp = "caa0387c-a617-44bc-97b5-170a79052739",
                            SpolId = 2,
                            TwoFactorEnabled = false
                        });
                });

            modelBuilder.Entity("SeminarskiTest.Models.Narudzba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DatumNarudzbe")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DostavljacId")
                        .HasColumnType("int");

                    b.Property<int?>("KarticaId")
                        .HasColumnType("int");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("KorisnikID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.Property<double>("TotalCijena")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DostavljacId");

                    b.HasIndex("KarticaId");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Prodavnica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prodavnica");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Proizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BrendId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<int?>("DobavljacId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("KategorijaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("NazivProizvoda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerijskiBroj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ValutaId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrendId");

                    b.HasIndex("DobavljacId");

                    b.HasIndex("KategorijaId");

                    b.HasIndex("ValutaId");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Slika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ProizvodId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("SlikaProizvoda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Slika");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Spol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NazivSpola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spol");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            NazivSpola = "Zenski"
                        });
                });

            modelBuilder.Entity("SeminarskiTest.Models.Valuta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Valuta");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SeminarskiTest.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SeminarskiTest.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiTest.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SeminarskiTest.Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarskiTest.Models.Dobavljac", b =>
                {
                    b.HasOne("SeminarskiTest.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Dostavljac", b =>
                {
                    b.HasOne("SeminarskiTest.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Korisnik", b =>
                {
                    b.HasOne("SeminarskiTest.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiTest.Models.Spol", "Spol")
                        .WithMany()
                        .HasForeignKey("SpolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");

                    b.Navigation("Spol");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Narudzba", b =>
                {
                    b.HasOne("SeminarskiTest.Models.Dostavljac", "Dostavljac")
                        .WithMany()
                        .HasForeignKey("DostavljacId");

                    b.HasOne("SeminarskiTest.Models.Kartica", "Kartica")
                        .WithMany()
                        .HasForeignKey("KarticaId");

                    b.HasOne("SeminarskiTest.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiTest.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId");

                    b.Navigation("Dostavljac");

                    b.Navigation("Kartica");

                    b.Navigation("Korisnik");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Proizvod", b =>
                {
                    b.HasOne("SeminarskiTest.Models.Brend", "Brend")
                        .WithMany()
                        .HasForeignKey("BrendId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiTest.Models.Dobavljac", "Dobavljac")
                        .WithMany()
                        .HasForeignKey("DobavljacId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiTest.Models.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarskiTest.Models.Valuta", "Valuta")
                        .WithMany()
                        .HasForeignKey("ValutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brend");

                    b.Navigation("Dobavljac");

                    b.Navigation("Kategorija");

                    b.Navigation("Valuta");
                });

            modelBuilder.Entity("SeminarskiTest.Models.Slika", b =>
                {
                    b.HasOne("SeminarskiTest.Models.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proizvod");
                });
#pragma warning restore 612, 618
        }
    }
}
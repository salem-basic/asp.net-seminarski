﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SeminarskiTest.Helper;
using SeminarskiTest.Models;

namespace SeminarskiTest.Data
{
    public class AppDbContext : IdentityDbContext<Korisnik>
    {
        public DbSet<Valuta> Valuta { get; set; }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Kartica> Kartica { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Korpa> Korpa { get; set; }
        public DbSet<KorpaProizvod> KorpaProizvod { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<Slika> Slika { get; set; }
        public DbSet<Transakcija> Transakcija { get; set; }
        public DbSet<Brend> Brend { get; set; }
        public DbSet<Dobavljac> Dobavljac { get; set; }
        public DbSet<SpecialOffer> SpecialOffer { get; set; }
        public DbSet<EvidencijaZaposlenika> EvidencijaZaposlenika { get; set; }
        public DbSet<Spol> Spol { get; set; }




        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RoleConfiguration());
            //builder.ApplyConfiguration(new KorisnikConfiguration());

            builder.Entity<Drzava>().HasData(
             new Drzava
             {
                 Id = 2,
                 NazivDrzave = "Hrvatska",
                 Sifra = "aslknioasfnewlr",
                 Skracenica = "HR"
             });

            builder.Entity<Spol>().HasData(
              new Spol
              {
                  Id = 2,
                  NazivSpola = "Zenski"
              });

            builder.Entity<Korisnik>().HasData(
                new Korisnik
                {
                    Ime = "Hamza",
                    Prezime = "Taslidza",
                    DatumRodjenja = DateTime.Now,
                    Grad = "Mostar",
                    BrojTelefona = "123",
                    Adresa = "Mahala",
                    Lozinka = "Lozinka1@",
                    Email = "salem@seminarski.com",
                    DrzavaId = 2,
                    SpolId = 2
                });

            builder.Entity<Proizvod>().HasOne(x => x.Dobavljac).WithMany(y => y.Proizvodi).OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(builder);
        }
    }
}

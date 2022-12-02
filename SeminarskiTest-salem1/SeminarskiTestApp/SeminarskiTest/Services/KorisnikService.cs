using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class KorisnikService : GenericRepository<Korisnik, KorisnikVModel, object>, IKorisnikService
    {
        private readonly AppDbContext _db;


        public KorisnikService(AppDbContext db, IMapper mapper) : base(mapper, db)
        {
            _db = db;
        }

        public override IQueryable<Korisnik> AddInclude(IQueryable<Korisnik> query)
        {
            query = query.Include(x => x.Drzava).Include(x => x.Spol);

            return query;
        }

        //private readonly AppDbContext db;

        //public KorisnikService(AppDbContext _db)
        //{
        //    db = _db;
        //}

        //public IEnumerable<Korisnik> Get()
        //{
        //    var model = db.Korisnik.Include(d => d.Drzava).Include(s=> s.Spol).AsQueryable().ToList();

        //    return model;
        //}

        //public void Add(KorisnikVModel x)
        //{
        //    var model = new Korisnik
        //    {
        //        Ime = x.Ime,
        //        Prezime = x.Prezime,
        //        Adresa = x.Adresa,
        //        BrojTelefona = x.BrojTelefona,
        //        DatumRodjenja = x.DatumRodjenja,
        //        DrzavaId = x.DrzavaID,
        //        Grad = x.Grad,
        //        SpolId = x.SpolId,
        //        KorisnickoIme = x.KorisnickoIme,
        //        Email = x.Email,
        //        Lozinka = x.Lozinka
        //    };

        //    db.Add(model);
        //    db.SaveChanges();
        //}

        //public void AddUloga(int id, int idUloga)
        //{
        //    var entity = db.Korisnik.Find(id);

        //    var uloga = db.Uloga.Find(idUloga);

        //    var novaUloga = new KorisnikUloga
        //    {
        //        KorisnikId = entity.Id,
        //        UlogaId = uloga.Id,
        //        DatumIzmjene = DateTime.Now,
        //    };

        //    db.Add(novaUloga);
        //    db.SaveChanges();
        //}

        //public void Update(int id, KorisnikVModel x)
        //{
        //    var korisnik = db.Korisnik.FirstOrDefault(x => x.Id == id);

        //    korisnik.Ime = x.Ime;
        //    korisnik.Prezime = x.Prezime;
        //    korisnik.Adresa = x.Adresa;
        //    korisnik.BrojTelefona = x.BrojTelefona;
        //    korisnik.DatumRodjenja = x.DatumRodjenja;
        //    korisnik.Grad = x.Grad;
        //    korisnik.SpolId = x.SpolId;
           

        //    db.SaveChanges();
        //}

        //public void Delete(int id)
        //{
        //    var korisnik = db.Korisnik.FirstOrDefault(x => x.Id == id);

        //    db.Remove(korisnik);
        //    db.SaveChanges();
        //}

        //private readonly AppDbContext context;

        //public Korisnik Login(string username, string password)
        //{
        //    var user = context.Korisnik.Include("KorisnikUloga.Uloga").FirstOrDefault(x => x.KorisnickoIme == username && x.Lozinka == password);

        //    if (user == null) { return null; }

        //    return user;
        //}
    }
}

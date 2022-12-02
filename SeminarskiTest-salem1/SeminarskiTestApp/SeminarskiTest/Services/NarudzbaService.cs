using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class NarudzbaService : GenericRepository<Narudzba, NarudzbaVModel, object>, INaruzdbaService
    {
        private readonly AppDbContext _db;


        public NarudzbaService(AppDbContext db, IMapper mapper) : base(mapper, db)
        {
            _db = db;
        }

        public override IQueryable<Narudzba> AddInclude(IQueryable<Narudzba> query)
        {
            query = query.Include(x => x.Proizvod).Include(x => x.Korisnik);

            return query;
        }

        //private readonly AppDbContext db;

        //public NarudzbaService(AppDbContext _db)
        //{
        //    db = _db;
        //}

        //public IEnumerable<Narudzba> Get()
        //{
        //    var model = db.Narudzba.AsQueryable().ToList();
        //    return model;
        //}

        //public void Add(NarudzbaVModel x)
        //{
        //    var model = new Narudzba
        //    {
        //        DatumNarudzbe = x.DatumNarudzbe,
        //        KorisnikId = x.KorisnikId,
        //        ProizvodId = x.ProizvodId
        //    };
        //    db.Add(model);
        //    db.SaveChanges();
        //}

        //public void Update(int id, NarudzbaVModel x)
        //{
        //    var model = db.Narudzba.FirstOrDefault(x => x.Id == id);

        //    model.DatumNarudzbe = x.DatumNarudzbe;
        //    model.KorisnikId = x.KorisnikId;
        //    model.ProizvodId = x.ProizvodId;

        //    db.SaveChanges();
        //}

        //public void Delete(int id)
        //{
        //    var model = db.Narudzba.FirstOrDefault(x => x.Id == id);

        //    db.Remove(model);
        //    db.SaveChanges();
        //}
    }
}

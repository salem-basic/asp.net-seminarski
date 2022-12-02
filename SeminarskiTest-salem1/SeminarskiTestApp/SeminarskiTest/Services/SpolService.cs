using AutoMapper;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class SpolService : GenericRepository<Spol, SpolVModel, object>, ISpolService
    {
        private readonly AppDbContext _db;

        public SpolService(AppDbContext db, IMapper mapper) : base(mapper, db)
        {
            _db = db;
        }
        //private readonly AppDbContext db;

        //public SpolService(AppDbContext _db)
        //{
        //    db = _db;
        //}

        //public IEnumerable<Spol> Get()
        //{
        //    var model = db.Spol.AsQueryable().ToList();
        //    return model;
        //}

        //public void Add(SpolVModel x)
        //{
        //    var model = new Spol
        //    {
        //        NazivSpola = x.NazivSpola
        //    };
        //    db.Add(model);
        //    db.SaveChanges();
        //}

        //public void Update(int id, SpolVModel x)
        //{
        //    var model = db.Spol.FirstOrDefault(x => x.Id == id);

        //    model.NazivSpola = x.NazivSpola;

        //    db.SaveChanges();
        //}

        //public void Delete(int id)
        //{
        //    var model = db.Spol.FirstOrDefault(x => x.Id == id);

        //    db.Remove(model);
        //    db.SaveChanges();
        //}
    }
}

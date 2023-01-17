using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class RecenzijaService : GenericRepository<Recenzija, RecenzijaVModel, object>, IRecenzijaService
    {
        private readonly AppDbContext _db;


        public RecenzijaService(AppDbContext db, IMapper mapper) : base(mapper, db)
        {
            _db = db;
        }


        public override IQueryable<Recenzija> AddInclude(IQueryable<Recenzija> query)
        {
            query = query.Include(k => k.korisnik).Include(p => p.proizvod);

            return query;
        }
    }
}

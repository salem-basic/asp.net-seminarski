using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SeminarskiTest.Data;
using SeminarskiTest.Helper;
using SeminarskiTest.Models;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class BrendService : GenericRepository<Brend, BrendVModel, BaseSearchObject>, IBrendService
    {
        private readonly AppDbContext _db;
        public BrendService(AppDbContext db, IMapper mapper) : base(mapper, db)
        {
            _db = db;
        }

        public override PagedList<Brend> GetPaged(IQueryable<Brend> entity, BaseSearchObject search)
        {
            return PagedList<Brend>.ToPagedList(entity, search.PageNumber, search.PageSize);
        }

        public override IQueryable<Brend> AddInclude(IQueryable<Brend> query)
        {
            query = query.Include(d => d.Drzava);

            return query;
        }
    }
}

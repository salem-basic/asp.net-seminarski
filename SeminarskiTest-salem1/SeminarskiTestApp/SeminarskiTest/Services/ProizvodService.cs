using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SeminarskiTest.Data;
using SeminarskiTest.Helper;
using SeminarskiTest.Models;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;
using System.Security.Cryptography;

namespace SeminarskiTest.Services
{
    public class ProizvodService : GenericRepository<Proizvod, ProizvodVModel, ProizvodiSearchObject>, IProizvodService
    {
        private readonly AppDbContext _db;


        public ProizvodService(AppDbContext db, IMapper mapper) : base(mapper,db)
        {
            _db = db;
        }

        public override IQueryable<Proizvod> AddInclude(IQueryable<Proizvod> query)
        {
            query = query.Include(v => v.Valuta).Include(k => k.Kategorija).Include(kk => kk.Korisnik).Include(d => d.Dobavljac).Include(b => b.Brend);

            return query;
        }

        public override IQueryable<Proizvod> AddQuery(IQueryable<Proizvod> query, ProizvodiSearchObject search)
        {
            if (!string.IsNullOrWhiteSpace(search.Naziv))
            {
                query = query.Where(x => x.NazivProizvoda.StartsWith(search.Naziv));
            }

            if (search.DobavljacSearch > 0)
            {
                query = query.Where(x => x.Dobavljac.Id == search.DobavljacSearch);
            }

            if (search.ComboBoxSearch == "AbecedaUnazad")
            {
                query = query.OrderByDescending(x => x.NazivProizvoda);
            }

            if (search.ComboBoxSearch == "Abeceda")
            {
                query = query.OrderBy(x => x.Cijena);
            }

            if (search.ComboBoxSearch == "CijenaNajskuplje")
            {
                query = query.OrderByDescending(x => x.Cijena);
            }

            if (search.ComboBoxSearch == "CijenaJeftino")
            {
                query = query.OrderBy(x => x.Cijena);
            }

            return query;
        }

        public PagedList<Proizvod> GetPaged(ProizvodiSearchObject search)
        {
            var entity = _db.Proizvod.AsQueryable();

            entity = AddInclude(entity);

            entity = AddQuery(entity, search);

            return PagedList<Proizvod>.ToPagedList(entity, search.PageNumber, search.PageSize);
        }
    }
}

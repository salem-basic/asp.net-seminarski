using AutoMapper;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class KategorijaService : GenericRepository<Kategorija, KategorijaVModel, object>, IKategorijaService
    {
        private readonly AppDbContext db;

        public KategorijaService(AppDbContext _db, IMapper mapper) : base(mapper, _db)
        {
            db = _db;
        }

    }
}

using AutoMapper;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class KarticaService : GenericRepository<Kartica, KarticaVModel, object>, IKarticaService
    {
        private readonly AppDbContext db;

        public KarticaService(AppDbContext _db, IMapper mapper) : base(mapper, _db)
        {
            db = _db;
        }

    }
}

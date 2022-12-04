using AutoMapper;
using SeminarskiTest.Data;
using SeminarskiTest.Models;
using SeminarskiTest.SearchObject;
using SeminarskiTest.Services.Interfaces;
using SeminarskiTest.Services.Repository;
using SeminarskiTest.ViewModels;

namespace SeminarskiTest.Services
{
    public class ValutaService : GenericRepository<Valuta, ValutaVModel, object>, IValutaService
    {
        private readonly AppDbContext _db;
      
        public ValutaService(AppDbContext db, IMapper mapper) : base(mapper, db)
        {
            _db = db;
        }
    }
}
